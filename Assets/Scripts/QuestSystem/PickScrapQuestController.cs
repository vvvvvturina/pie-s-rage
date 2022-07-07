﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace QuestSystem
{
    public class PickScrapQuestController : QuestController
    {
        public QuestManager questManager;
        private void Awake()
        {
            //thisQuest = new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it");
            //questManager.Quests.Add(Quest);
        }
        
        public void EndQuest()
        { 
            questManager.CompleteQuest(thisQuest);
            questManager.Quests.Remove(thisQuest);
        }

        public void Start()
        {
            thisQuest = questManager.Quests[1];
        }
        

        public void OnMouseDown()
        {
            EndQuest();
            questManager.DisplayQuest();
        }
    }
}