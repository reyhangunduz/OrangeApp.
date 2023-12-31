﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YemekKalori.BLL.Services;
using YemekKalori.Domain.Entities;

namespace YemekKalori.UI
{
    public partial class PortionScreen : Form
    {
        public PortionScreen()
        {
            InitializeComponent();
        }

        public PortionScreen(int foodId, UserScreen frm)
        {
            InitializeComponent();
            this.foodId = foodId;
            this.frm = frm;
        }

        public PortionScreen(MealFood mealFood, UserScreen frm)
        {
            InitializeComponent();
            this.mealFood = mealFood;
            this.frm = frm;
            foodId = mealFood.FoodId;
        }

        MealFood mealFood;
        UserScreen frm;
        int foodId;
        List<Decimal> portions;
        private void PortionScreen_Load(object sender, EventArgs e)
        {
            portions = new List<decimal> { 0.5m, 1.0m, 1.5m, 2.0m, 2.5m, 3.0m, 3.5m, 4.0m, 4.5m, 5.0m };

            cbPortions.DataSource = portions;

            foodService = new FoodService();

            Food food = foodService.GetFoodById(foodId);

            lblYemekAd.Text = food.Name;

            pbFoodPic.ImageLocation = food.FoodPic;

            lblPorsiyonTanim.Text = food.PortionDesc;

            cbPortions.SelectedIndex = -1;

        }

        FoodService foodService;

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (mealFood == null)
            {
                if (cbPortions.SelectedIndex != -1)
                {
                    MealFood mealFood = new MealFood()
                    {
                        FoodId = foodId,
                        Name = foodService.GetFoodById(foodId).Name,
                        Portion = (decimal)cbPortions.SelectedItem
                    };

                    //mealFood.Food = foodService.GetFoodById(foodId);


                    frm.RetrieveMealFood(mealFood);

                    this.Close();
                }
            }
            else
            {
                if (cbPortions.SelectedIndex != -1)
                {
                    mealFood.Portion = (decimal)cbPortions.SelectedItem;
                    frm.RetrieveMealFood(mealFood);

                    this.Close();
                }
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
