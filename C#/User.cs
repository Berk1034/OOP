///////////////////////////////////////////////////////////
//  User.cs
//  Implementation of the Class User
//  Generated by Enterprise Architect
//  Created on:      10-���-2019 13:37:02
//  Original author: user
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



using PredatoryPlantsOnlineStore;
namespace PredatoryPlantsOnlineStore {
	public class User {

		private Cart cart;
		private string email;
		private string password_hash;
		private string role;
		private int role_ID;
		private int user_ID;
		public PredatoryPlantsOnlineStore.Order m_Order;

		public User(){

		}

		~User(){

		}

		/// 
		/// <param name="id_product"></param>
		public void AddFlowerToCart(int id_product){

		}

		public Order Order{
			get;
			set;
		}

		public void SignOut(){

		}

		public void ViewCart(){

		}

		public void ViewCatalogue(){

		}

		/// 
		/// <param name="id_product"></param>
		public void ViewPredatoryPlantInfo(int id_product){

		}

	}//end User

}//end namespace PredatoryPlantsOnlineStore