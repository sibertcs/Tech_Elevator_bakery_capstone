﻿using SampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.DAL
{
    /// <summary>
    /// A SQL Dao for cake options.
    /// </summary>
    public interface ICakeOptionsDAO
    {

        /// <summary>
        /// adds a style to our database so that is available for customers in the drop down menu
        /// </summary>
        /// <returns></returns>
        bool AddStyleOption(Styles newStyle);
        
        ///<Summary>
        /// Returns a list of cake styles stored in our SQL database
        ///</Summary>
        List<Styles> GetAllCakeStyles();

        /// <summary>
        /// adds a size to our database so that is available for customers in the drop down menu
        /// </summary>
        /// <returns></returns>
        bool AddSizeOption(Sizes newSize);
        
        ///<Summary>
        /// Returns a list of cake sizes stored in our SQL database
        ///</Summary>
        List<Sizes> GetAllCakeSizes();

        /// <summary>
        /// adds a frosting to our database so that is available for customers in the drop down menu
        /// </summary>
        /// <returns></returns>
        bool AddFrostingOption(Frostings newFrosting);

        ///<Summary>
        /// Returns a list of cake frostings stored in our SQL database
        ///</Summary>
        List<Frostings> GetAllCakeFrostings();

        




    }
}
