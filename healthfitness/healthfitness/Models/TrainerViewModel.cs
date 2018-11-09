using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using healthfitness.Models;
using healthfitness.Views;
using Xamarin.Forms;

namespace healthfitness.Models
{
    public class TrainerViewModel
    {
        public IList<TrainerDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }
        public TrainerViewModel()
        {
            CardDataCollection = new List<TrainerDataModel>();
            GenerateCardModel();
        }

        

        private void GenerateCardModel()
        {

            CardDataCollection = new ObservableCollection<TrainerDataModel>
                {
                    new TrainerDataModel
                    {
                     HeadTitle = " 1 day ago   - Kelly ",

                     HeadLines="My fitness journey from 140 kg to a proud 76 kg. This was poosible through Fitness4U!! " ,
                     ProfileImage = "Person_1.jpg",
                     HeadLinesDesc = "In 2010, Kelly decided it was time to make a change. So she started blogging about losing weight. She credits the bulk of her weight loss in those early years to Jenny Craig. Today, she writes about how she manages to keep the weight off. No Thanks to Cake is full of healthy recipes that are sure to make your mouth water. There’s also plenty of inspiration for people starting out on their own weight loss journey.",
                     TargetType=typeof(arms)
                    },



                     new TrainerDataModel
                    {
                     HeadTitle = " 9 hrs ago   - Mark",
                     HeadLines="My fitness journey from 130 kg to a proud 86 kg. This was poosible through Fitness4U!! " ,
                     HeadLinesDesc = "Marks’s weight has been a challenge her entire life. But after having two boys, she reached an all-time high: 253 pounds. That was when she decided to make a change, but it didn’t happen right away. For the next three years, she dieted and bounced between losing and gaining 50 pounds. Her real weight loss journey began in 2009, when she used calorie counting and running to take off 125 pounds. Today, she writes about maintaining that loss, running, being a mother, and managing a bipolar diagnosis.",
                     TargetType=typeof(arms),
                     ProfileImage = "Person_2.png"
                     },



                      new TrainerDataModel
                    {
                    HeadTitle       = " 10 hrs ago  - John",
                     HeadLines="My fitness journey from 100 kg to a proud 72 kg. This was poosible through Fitness4U!! " ,
                     HeadLinesDesc     = "John’s weight has been a challenge her entire life. But after having two boys, she reached an all-time high: 253 pounds. That was when she decided to make a change, but it didn’t happen right away. For the next three years, she dieted and bounced between losing and gaining 50 pounds. Her real weight loss journey began in 2009, when she used calorie counting and running to take off 125 pounds. Today, she writes about maintaining that loss, running, being a mother, and managing a bipolar diagnosis.",
                     TargetType=typeof(arms),
                      ProfileImage     = "Person_3.png"
                      },


                       new TrainerDataModel
                    {
                    HeadTitle = " 13 hrs ago  - Ryan ",
                     HeadLines="My fitness journey from 140 kg to a proud 76 kg. This was poosible through Fitness4U!! " ,
                     HeadLinesDesc="My story is not one of overnight success. I didn’t take a magic pill. My results were not from a fad diet or a product from an infomercial. My journey has been more like a roller coaster ride of trials, many errors, and a collection of small milestones along the way, eventually leading to more than I ever expected to gain",
                     ProfileImage = "Person_4.jpg",
                     TargetType=typeof(arms)

                       },


                        new TrainerDataModel
                    {
                    HeadTitle= " 15 hrs ago - Brian",
                   HeadLinesDesc  = "My story is not one of overnight success. I didn’t take a magic pill. My results were not from a fad diet or a product from an infomercial. My journey has been more like a roller coaster ride of trials, many errors, and a collection of small milestones along the way, eventually leading to more than I ever expected to gain" ,
                     HeadLines="My fitness journey from 140 kg to a proud 76 kg. This was poosible through Fitness4U!! " ,
                     ProfileImage = "Person_5.jpg",
                     TargetType=typeof(arms)
                        },


                         new TrainerDataModel
                    {
                      HeadTitle = " 16 hrs ago - Mac",
                      HeadLinesDesc = "My story is not one of overnight success. I didn’t take a magic pill. My results were not from a fad diet or a product from an infomercial. My journey has been more like a roller coaster ride of trials, many errors, and a collection of small milestones along the way, eventually leading to more than I ever expected to gain",
                     HeadLines="My fitness journey from 140 kg to a proud 76 kg. This was poosible through Fitness4U!! " ,
                      ProfileImage = "Person_1.png",
                      TargetType=typeof(arms)
                         },


                          new TrainerDataModel
                    {
                     HeadTitle = " 19 hrs ago  - Andy",
                      HeadLinesDesc = "My story is not one of overnight success. I didn’t take a magic pill. My results were not from a fad diet or a product from an infomercial. My journey has been more like a roller coaster ride of trials, many errors, and a collection of small milestones along the way, eventually leading to more than I ever expected to gain",
                     HeadLines="My fitness journey from 140 kg to a proud 76 kg. This was poosible through Fitness4U!! " ,
                      ProfileImage = "Person_2.png",
                      TargetType=typeof(arms)
                          },
                   
                 //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model
                };


        }
    }
}
