// DFS

void Search(Node root)
{
	if(root == null)
	{
		return;
	}
	
	root.visited == true;
	foreach(Node n in root.adjacent)
	{
		if(n.visited == false)
		{
			Search(n);
		}
	}
}

// BFS

void search (Node root)
{
	Queue queue = new Queue();
	root.visited = true;
	visit(root);
	queue.Enqueue(root);
	
	while(!queue.IsEmpty)
	{
		Node r = queue.Dequeue();
		foreach(Node n in r.adjacent)
		{
			if(n.visited == false)
			}{
				visit(n);
				n.visited == true;
				queue.Enqueue(n);
			}
		}
	}
	
}


