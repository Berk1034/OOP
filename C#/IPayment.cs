///////////////////////////////////////////////////////////
//  IPayment.cs
//  Implementation of the Interface IPayment
//  Generated by Enterprise Architect
//  Created on:      10-���-2019 13:37:01
//  Original author: user
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace PredatoryPlantsOnlineStore {
	public interface IPayment  {

		void CheckPayment();

		void SendTransaction();
	}//end IPayment

}//end namespace PredatoryPlantsOnlineStore