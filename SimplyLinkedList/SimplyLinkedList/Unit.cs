using System; namespace SimplyLinkedList {
	public class Unit<T>
	{
		public Unit(T data)
		{
			Data = data;
		}

		public T Data { get; set; }
		public Unit<T> Next { get; set; }
	} } 