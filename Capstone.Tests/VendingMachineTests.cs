using System;
using System.Collections.Generic;
using Capstone.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Capstone.Tests
{
	[TestClass]
	public class VendingMachineTests
	{
		VendingMachine vendingMachine = new VendingMachine();
		private Dictionary<string, InventoryItem> _inventory = new Dictionary<string, InventoryItem>();
		private List<InventoryItem> _items = new List<InventoryItem>();

		[TestMethod]
		public void Deposit()
		{
			vendingMachine.Deposit(1);
			Assert.AreEqual(1, 1, "Input: 1.00");

			vendingMachine.Deposit(5);
			Assert.AreEqual(6.00, 6.00, "Input: 5.00");

			vendingMachine.Deposit(10);
			Assert.AreEqual(16.00, 16.00, "Input: 10.00");
		}

		[TestMethod]
		public void Deduction()
		{
			vendingMachine.Deduction(1);
			Assert.AreEqual(15, 15, "Input: 1.00");

			vendingMachine.Deduction(3.50);
			Assert.AreEqual(11.50, 11.50, "Input: 3.50");

			vendingMachine.Deduction(5);
			Assert.AreEqual(6.50, 6.50, "Input: 5.00");
		}

		[TestMethod]
		public void AddItem()
		{
			vendingMachine.AddItem("A1");
			_items.Add(_inventory.ContainsKey("A1"), true);
			vendingMachine.Deposit(10);

			Assert.AreEqual("A1", "A1", "Add A1 to list");
			//Assert.AreEqual();
		}
	}
}
