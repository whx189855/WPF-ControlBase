﻿using HeBianGu.Base.WpfBase;
using HeBianGu.Common.TestData;
using HeBianGu.Service.Mvc;
using System;
using System.Collections.ObjectModel;

namespace HeBianGu.App.Manager
{
    [ViewModel("Loyout")]
    internal class LoyoutViewModel : MvcViewModelBase
    {
        private ObservableCollection<Persion> _collection = new ObservableCollection<Persion>();
        /// <summary> 说明  </summary>
        public ObservableCollection<Persion> Collection
        {
            get { return _collection; }
            set
            {
                _collection = value;
                RaisePropertyChanged("Collection");
            }
        }




        protected override void Init()
        {
            Collection = Persion.Create().ToObservable();
        }


        protected override void Loaded(string args)
        {

        }


        /// <summary> 命令通用方法 </summary>
        protected override async void RelayMethod(object obj)

        {
            string command = obj?.ToString();

            //  Do：对话消息
            if (command == "Sumit")
            {

            }

            //  Do：等待消息
            else if (command == "Cancel")
            {

            }
        }

    }
}
