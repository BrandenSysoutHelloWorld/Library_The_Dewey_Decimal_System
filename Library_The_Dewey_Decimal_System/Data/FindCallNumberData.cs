using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Library_The_Dewey_Decimal_System.Models
{
    /// <summary>
    /// Processing Class. Using TreeNodes, Queue's, Dictionaries and JSON.
    /// Call-Numbers are read from a JSON File into a TreeNode. TreeNodes are then sent to the View.
    /// </summary>
    public class FindCallNumberData    {

        public string key;
        Queue<string> queue = new Queue<string>();
        public TreeNode<string> CreateTree()
        {
            string initial = string.Empty;
            string a = string.Empty;
            string b = string.Empty;
            string c = string.Empty;
            string d = string.Empty;
            string e = string.Empty;
            string f = string.Empty;
            string g = string.Empty;
            string h = string.Empty;
            string i = string.Empty;
            string j = string.Empty;

            TreeNode<string> root = new TreeNode<string>("Default");
            var json = string.Empty;
            using (StreamReader file = File.OpenText("LayeredCallNumbers.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {

                JObject o2 = (JObject)JToken.ReadFrom(reader);
                string response = o2.ToString();


                for (int loop = 0; loop < response.Length; loop++)
                {
                    json += response[loop].ToString();
                }
            }
            var jObj = JObject.Parse(json);
            // General
            JObject top0 = (JObject)jObj["000"];
            JObject _000 = (JObject)jObj["_000"];
            queue.Clear();
            foreach (var item in top0)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _000)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial0 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial0.AddChild(a);
                TreeNode<string> nodeB = nodeInitial0.AddChild(b);
                TreeNode<string> nodeC = nodeInitial0.AddChild(c);
                TreeNode<string> nodeD = nodeInitial0.AddChild(d);
                TreeNode<string> nodeE = nodeInitial0.AddChild(e);
                TreeNode<string> nodeF = nodeInitial0.AddChild(f);
                TreeNode<string> nodeG = nodeInitial0.AddChild(g);
                TreeNode<string> nodeH = nodeInitial0.AddChild(h);
                TreeNode<string> nodeI = nodeInitial0.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial0.AddChild(j);
            }
            // Phys
            JObject top1 = (JObject)jObj["100"];
            JObject _100 = (JObject)jObj["_100"];
            queue.Clear();
            foreach (var item in top1)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _100)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial1 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial1.AddChild(a);
                TreeNode<string> nodeB = nodeInitial1.AddChild(b);
                TreeNode<string> nodeC = nodeInitial1.AddChild(c);
                TreeNode<string> nodeD = nodeInitial1.AddChild(d);
                TreeNode<string> nodeE = nodeInitial1.AddChild(e);
                TreeNode<string> nodeF = nodeInitial1.AddChild(f);
                TreeNode<string> nodeG = nodeInitial1.AddChild(g);
                TreeNode<string> nodeH = nodeInitial1.AddChild(h);
                TreeNode<string> nodeI = nodeInitial1.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial1.AddChild(j);
            }
            // Phys
            JObject top2 = (JObject)jObj["200"];
            JObject _200 = (JObject)jObj["_200"];
            queue.Clear();
            foreach (var item in top2)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _200)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial2 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial2.AddChild(a);
                TreeNode<string> nodeB = nodeInitial2.AddChild(b);
                TreeNode<string> nodeC = nodeInitial2.AddChild(c);
                TreeNode<string> nodeD = nodeInitial2.AddChild(d);
                TreeNode<string> nodeE = nodeInitial2.AddChild(e);
                TreeNode<string> nodeF = nodeInitial2.AddChild(f);
                TreeNode<string> nodeG = nodeInitial2.AddChild(g);
                TreeNode<string> nodeH = nodeInitial2.AddChild(h);
                TreeNode<string> nodeI = nodeInitial2.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial2.AddChild(j);
            }
            // Phys
            JObject top3 = (JObject)jObj["300"];
            JObject _300 = (JObject)jObj["_300"];
            queue.Clear();
            foreach (var item in top3)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _300)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial3 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial3.AddChild(a);
                TreeNode<string> nodeB = nodeInitial3.AddChild(b);
                TreeNode<string> nodeC = nodeInitial3.AddChild(c);
                TreeNode<string> nodeD = nodeInitial3.AddChild(d);
                TreeNode<string> nodeE = nodeInitial3.AddChild(e);
                TreeNode<string> nodeF = nodeInitial3.AddChild(f);
                TreeNode<string> nodeG = nodeInitial3.AddChild(g);
                TreeNode<string> nodeH = nodeInitial3.AddChild(h);
                TreeNode<string> nodeI = nodeInitial3.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial3.AddChild(j);
            }
            // Phys
            JObject top4 = (JObject)jObj["400"];
            JObject _400 = (JObject)jObj["_400"];
            queue.Clear();
            foreach (var item in top4)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _400)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial4 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial4.AddChild(a);
                TreeNode<string> nodeB = nodeInitial4.AddChild(b);
                TreeNode<string> nodeC = nodeInitial4.AddChild(c);
                TreeNode<string> nodeD = nodeInitial4.AddChild(d);
                TreeNode<string> nodeE = nodeInitial4.AddChild(e);
                TreeNode<string> nodeF = nodeInitial4.AddChild(f);
                TreeNode<string> nodeG = nodeInitial4.AddChild(g);
                TreeNode<string> nodeH = nodeInitial4.AddChild(h);
                TreeNode<string> nodeI = nodeInitial4.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial4.AddChild(j);
            }
            // Phys
            JObject top5 = (JObject)jObj["500"];
            JObject _500 = (JObject)jObj["_500"];
            queue.Clear();
            foreach (var item in top5)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _500)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial5 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial5.AddChild(a);
                TreeNode<string> nodeB = nodeInitial5.AddChild(b);
                TreeNode<string> nodeC = nodeInitial5.AddChild(c);
                TreeNode<string> nodeD = nodeInitial5.AddChild(d);
                TreeNode<string> nodeE = nodeInitial5.AddChild(e);
                TreeNode<string> nodeF = nodeInitial5.AddChild(f);
                TreeNode<string> nodeG = nodeInitial5.AddChild(g);
                TreeNode<string> nodeH = nodeInitial5.AddChild(h);
                TreeNode<string> nodeI = nodeInitial5.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial5.AddChild(j);
            }
            // Phys
            JObject top6 = (JObject)jObj["600"];
            JObject _600 = (JObject)jObj["_600"];
            queue.Clear();
            foreach (var item in top6)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _600)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial6 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial6.AddChild(a);
                TreeNode<string> nodeB = nodeInitial6.AddChild(b);
                TreeNode<string> nodeC = nodeInitial6.AddChild(c);
                TreeNode<string> nodeD = nodeInitial6.AddChild(d);
                TreeNode<string> nodeE = nodeInitial6.AddChild(e);
                TreeNode<string> nodeF = nodeInitial6.AddChild(f);
                TreeNode<string> nodeG = nodeInitial6.AddChild(g);
                TreeNode<string> nodeH = nodeInitial6.AddChild(h);
                TreeNode<string> nodeI = nodeInitial6.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial6.AddChild(j);
            }
            // Phys
            JObject top7 = (JObject)jObj["700"];
            JObject _700 = (JObject)jObj["_700"];
            queue.Clear();
            foreach (var item in top7)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _700)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue(); ;
            TreeNode<string> nodeInitial7 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial7.AddChild(a);
                TreeNode<string> nodeB = nodeInitial7.AddChild(b);
                TreeNode<string> nodeC = nodeInitial7.AddChild(c);
                TreeNode<string> nodeD = nodeInitial7.AddChild(d);
                TreeNode<string> nodeE = nodeInitial7.AddChild(e);
                TreeNode<string> nodeF = nodeInitial7.AddChild(f);
                TreeNode<string> nodeG = nodeInitial7.AddChild(g);
                TreeNode<string> nodeH = nodeInitial7.AddChild(h);
                TreeNode<string> nodeI = nodeInitial7.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial7.AddChild(j);
            }
            // Phys
            JObject top8 = (JObject)jObj["800"];
            JObject _800 = (JObject)jObj["_800"];
            queue.Clear();
            foreach (var item in top8)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _800)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial8 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial8.AddChild(a);
                TreeNode<string> nodeB = nodeInitial8.AddChild(b);
                TreeNode<string> nodeC = nodeInitial8.AddChild(c);
                TreeNode<string> nodeD = nodeInitial8.AddChild(d);
                TreeNode<string> nodeE = nodeInitial8.AddChild(e);
                TreeNode<string> nodeF = nodeInitial8.AddChild(f);
                TreeNode<string> nodeG = nodeInitial8.AddChild(g);
                TreeNode<string> nodeH = nodeInitial8.AddChild(h);
                TreeNode<string> nodeI = nodeInitial8.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial8.AddChild(j);
            }
            // Phys
            JObject top9 = (JObject)jObj["900"];
            JObject _900 = (JObject)jObj["_900"];
            queue.Clear();
            foreach (var item in top9)
            {
                queue.Enqueue(item.Value.ToString());
            }
            foreach (var subItem in _900)
            {
                queue.Enqueue(subItem.Value.ToString());
            }
            initial = queue.Dequeue();
            a = queue.Dequeue();
            b = queue.Dequeue();
            c = queue.Dequeue();
            d = queue.Dequeue();
            e = queue.Dequeue();
            f = queue.Dequeue();
            g = queue.Dequeue();
            h = queue.Dequeue();
            i = queue.Dequeue();
            j = queue.Dequeue();
            TreeNode<string> nodeInitial9 = root.AddChild(initial);
            {
                TreeNode<string> nodeA = nodeInitial9.AddChild(a);
                TreeNode<string> nodeB = nodeInitial9.AddChild(b);
                TreeNode<string> nodeC = nodeInitial9.AddChild(c);
                TreeNode<string> nodeD = nodeInitial9.AddChild(d);
                TreeNode<string> nodeE = nodeInitial9.AddChild(e);
                TreeNode<string> nodeF = nodeInitial9.AddChild(f);
                TreeNode<string> nodeG = nodeInitial9.AddChild(g);
                TreeNode<string> nodeH = nodeInitial9.AddChild(h);
                TreeNode<string> nodeI = nodeInitial9.AddChild(i);
                TreeNode<string> nodeJ = nodeInitial9.AddChild(j);
            }
            return root;
        }
        public TreeNode<string> getTree()
        {
            TreeNode<string> treeRoot = CreateTree();
            foreach (TreeNode<string> node in treeRoot)
            {
                string indent = CreateIndent(node.Level);
                // Console.WriteLine(indent + (node.Data ?? "null"));
            }
            return treeRoot;
        }

        private static String CreateIndent(int depth)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
            {
                sb.Append(' ');
            }
            return sb.ToString();
        }

    }
}


