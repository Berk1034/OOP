///////////////////////////////////////////////////////////
//  Transaction.cs
//  Implementation of the Class Transaction
//  Generated by Enterprise Architect
//  Created on:      10-���-2019 13:37:03
//  Original author: user
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using PredatoryPlantsOnlineStore;
namespace PredatoryPlantsOnlineStore {
	public class Transaction : IPayment {

		private DateTime date;
		private int id_transaction;
		private int number_bank_account;
		private int summ;
		public PredatoryPlantsOnlineStore.Order m_Order;

		public Transaction(){

		}

		~Transaction(){

		}

		public void CheckPayment(){

		}

		public DateTime GetDate(){

			return null;
		}

		public int GetPrice(){

			return 0;
		}

		public Order Order{
			get;
			set;
		}

		public void SendTransaction(){

		}

		/// 
		/// <param name="date"></param>
		public void SetDate(DateTime date){

		}

	}//end Transaction

}//end namespace PredatoryPlantsOnlineStore