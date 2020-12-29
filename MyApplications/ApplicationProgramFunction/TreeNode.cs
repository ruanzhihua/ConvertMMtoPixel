using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI.WebControls;

namespace ApplicationProgramFunction
{
    public class TreeNode
    {
        #region 成员
        public string parentID;
        public string currentID;
        public string nodeContent;
        public object nodeObj;
        public TreeNode parentNode;
        public List<TreeNode> childNodeList;

        #endregion
        public TreeNode()
        {
            InitNode();
        }
        public TreeNode(TreeNode initNode)
        {
            InitNode(initNode);
        }
        /// <summary>
        /// 用已有节点初始化新建节点
        /// </summary>
        /// <param name="initNode">已有节点</param>
        public void InitNode(TreeNode initNode = null)
        {
            if (childNodeList == null)
            {
                childNodeList = new List<TreeNode>();
            }
            parentID = "0";
            currentID = "root";
            nodeContent = "";
            nodeObj = null;

            if (initNode != null)
            {
                parentID = initNode.parentID;
                currentID = initNode.currentID;
                nodeContent = initNode.GetNodeContent();
                parentNode = initNode.getParentNode();
                if (initNode.GetChildNodeList() != null)
                {
                    childNodeList = new List<TreeNode>(initNode.GetChildNodeList());
                }
                if (initNode.GetNodeObj() != null)
                {
                    nodeObj = new Hashtable((Hashtable)initNode.GetNodeObj());
                }
            }

        }
        /// <summary>
        /// 获取父节点
        /// </summary>
        /// <returns></returns>
        public TreeNode getParentNode()
        {
            return parentNode;
        }
        /// <summary>
        /// 获取节点内容
        /// </summary>
        /// <returns></returns>
        public string GetNodeContent()
        {
            return nodeContent;
        }
        /// <summary>
        /// 获取子节点列表
        /// </summary>
        /// <returns></returns>
        public List<TreeNode> GetChildNodeList()
        {
            return childNodeList;
        }
        /// <summary>
        /// 获取节点绑定扩展对象
        /// </summary>
        /// <returns></returns>
        public Object GetNodeObj()
        {
            return nodeObj;
        }
        /// <summary>
        /// 设置父节点id
        /// </summary>
        /// <param name="parentIDStr"></param>
        public void SetParentID(String parentIDStr)
        {
            this.parentID = parentIDStr;
        }
        /// <summary>
        /// 设置节点内容
        /// </summary>
        /// <param name="strNodeContent"></param>
        public void SetNodeContent(string strNodeContent)
        {
            this.nodeContent = strNodeContent;
        }
        /// <summary>
        /// 设置父节点
        /// </summary>
        /// <param name="treeNode"></param>
        public void SetParentNode(TreeNode treeNode)
        {
            this.parentNode = treeNode;
        }
        /// <summary>
        /// 设置节点对象
        /// </summary>
        /// <param name="obj"></param>
        public void SetNodeObj(object obj)
        {
            this.nodeObj = obj;
        }
        /// <summary>
        /// 设置节点id
        /// </summary>
        /// <param name="strCurrentID"></param>
        public void SetCurrentID(string strCurrentID)
        {
            this.currentID = strCurrentID;
        }
        /// <summary>
        /// 插入子节点
        /// </summary>
        /// <param name="childTreeNode"></param>
        public void InsertChildNode(TreeNode childTreeNode)
        {
            if (childNodeList == null)
            {
                childNodeList = new List<TreeNode>();

            }
            childNodeList.Add(childTreeNode);
            childTreeNode.SetParentNode(this);
        }
        /// <summary>
        /// 在指定ID节点插入子节点
        /// </summary>
        /// <param name="strNodeID"></param>
        /// <param name="treeNode"></param>
        public void InsertChildNodeByID(string strNodeID, TreeNode treeNode)
        {
            if (strNodeID == treeNode.currentID)
            {
                ///节点冲突，操作非法
                throw new Exception("节点冲突，节点循环，操作非法");
            }
            if (strNodeID == "root")
            {
                throw new Exception("节点冲突，root为预设关键字，不允许使用");
            }
            if (this.currentID == "root")
            {
                parentID = treeNode.parentID;
                currentID = treeNode.currentID;
                childNodeList.AddRange(treeNode.childNodeList);
                nodeContent = treeNode.nodeContent;
                nodeObj = treeNode.nodeObj;
            }
            if (strNodeID == this.currentID)
            {
                this.InsertChildNode(new TreeNode(treeNode));
            }
            foreach (TreeNode tn in childNodeList)
            {
                tn.InsertChildNodeByID(strNodeID, treeNode);
            }
        }
        /// <summary>
        /// 是否末节点
        /// </summary>
        /// <returns></returns>
        public bool IsLastNode()
        {
            return childNodeList == null || childNodeList.Count == 0;
        }
        /// <summary>
        /// 递归获取所有叶节点路径
        /// </summary>
        /// <param name="pathList">路径集合</param>
        /// <param name="isContainsSelf">路径是否包含自身节点</param>
        public void FindAllLastNodePath(List<String> pathList, bool isContainsSelf)
        {
            if (IsLastNode())
            {
                List<TreeNode> list = getElders();
                string lastNodePath = string.Empty;
                foreach (TreeNode treeNode in list)
                {
                    if (treeNode != null)
                    {
                        if (lastNodePath.Length > 0) lastNodePath += "\\";
                        lastNodePath += treeNode.nodeContent;

                    }
                }
                if (isContainsSelf)
                {
                    lastNodePath += "\\" + nodeContent;
                }
                pathList.Add(lastNodePath);
            }
            else
            {
                foreach (TreeNode childTreeNode in childNodeList)
                {
                    childTreeNode.FindAllLastNodePath(pathList, isContainsSelf);
                }
            }
        }
        /// <summary>
        /// 获取父节点集合
        /// </summary>
        /// <returns></returns>
        public List<TreeNode> getElders()
        {
            List<TreeNode> parentNodeList = new List<TreeNode>();
            TreeNode treeNode = this.getParentNode();
            if (treeNode != null)
            {
                parentNodeList.AddRange(treeNode.getElders());
                parentNodeList.Add(treeNode);
                return parentNodeList;
            }
            else
            {
                return parentNodeList;
            }
        }

    }
}