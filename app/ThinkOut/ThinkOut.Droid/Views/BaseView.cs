
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ThinkOut.Droid.Helpers.MvvmCross;
using Cirrious.MvvmCross.ViewModels;
using Android.Graphics.Drawables;

namespace ThinkOut.Droid
{
    public class BaseView<T> : MvxActionBarActivity where T : MvxViewModel
    {
        private int _layoutResourceId;
        //        private bool _existsActionbar = false;

        //        protected int TopToolbarResourceId = Resource.Id.topToolbar;
        //        protected int BottomToolbarResourceId = Resource.Id.bottomToolbar;

        //        private bool _closeActivityOnBackButtonClicked = true;
        //        private string _pageTitle = null;
        //        private bool _supportActionBarHasTitle = false;
        //        private bool _supportActionBarHasBackButton = false;

        public T ViewModel
        {
            get
            {
                return base.ViewModel as T;
            }
            set
            {
                base.ViewModel = value;
            }

        }

        public BaseView(int layoutResourceId)
        {        
            _layoutResourceId = layoutResourceId;
        }

        protected override void OnCreate(Bundle bundle)
        {
            RequestedOrientation = Android.Content.PM.ScreenOrientation.Portrait;
            RequestWindowFeature(WindowFeatures.NoTitle); 
            Window.SetFlags(WindowManagerFlags.TranslucentStatus, WindowManagerFlags.TranslucentStatus);
            base.OnCreate(bundle);
            SetContentView(_layoutResourceId);    
//            ConfigureActionBars(); 
            CustomPresenter.Presenter.ViewModels.Add(this.ViewModel);
        }

        //        private void ConfigureActionBars()
        //        {
        //            var topToolbar = FindViewById <Android.Support.V7.Widget.Toolbar>(TopToolbarResourceId);
        //            if (!topToolbar.IsNull())
        //            {
        //                SetSupportActionBar(topToolbar);
        //                _existsActionbar = true;
        //                RemoveSupportActionBarBackButton();
        //                RemoveAddGoalActionFromActionBar();
        //                RemoveUserSettingsActionFromActionBar();
        //                RemoveSupportActionBarSearchFeature();
        //                RemoveSupportActionBarImage();
        //            }
        //        }
        //
        //        public void AddSupportActionBarTitle(string title)
        //        {
        //            _pageTitle = title;
        //
        //            if (_existsActionbar)
        //            {
        //                var txtView = FindViewById<TextView>(Resource.Id.topToolbarTxtTitle);
        //                txtView.Text = _pageTitle;
        //                txtView.Visibility = ViewStates.Visible;
        //                _supportActionBarHasTitle = true;
        //            }
        //        }
        //
        //        public void AddSupportActionBarTitle(int stringResourceId)
        //        {
        //            AddSupportActionBarTitle(Resources.GetString(stringResourceId));
        //        }
        //
        //        public void RemoveSupportActionBarImage()
        //        {
        //            if (_existsActionbar)
        //                FindViewById<ImageView>(Resource.Id.topToolbarImage).Visibility = ViewStates.Gone;
        //        }
        //
        //        public void AddSupportActionBarImage()
        //        {
        //            if (_existsActionbar)
        //                FindViewById<ImageView>(Resource.Id.topToolbarImage).Visibility = ViewStates.Visible;
        //        }
        //
        //        public void RemoveSupportActionBarTitle()
        //        {
        //            if (_existsActionbar)
        //                FindViewById<TextView>(Resource.Id.topToolbarTxtTitle).Visibility = ViewStates.Gone;
        //        }
        //
        //        public void SetSupportActionBarBackGroundColor(int idResourceColor)
        //        {
        //            this.SupportActionBar.SetBackgroundDrawable(new ColorDrawable(Resources.GetColor(idResourceColor)));
        //        }
        //
        //        protected void AddSupportActionBarSearchFeature()
        //        {
        //            if (_existsActionbar)
        //            {
        //                var actionSearch = FindViewById<ImageButton>(Resource.Id.actionSearch);
        //                actionSearch.Visibility = ViewStates.Visible;
        //                actionSearch.Click += actionSearchClicked;
        //                actionSearch.Visibility = ViewStates.Visible;
        //                var searchTxt = FindViewById<EditText>(Resource.Id.topToolbarSearchTxt);
        //                searchTxt.Visibility = ViewStates.Gone;
        //                searchTxt.EditorAction += txtSearchEditorAction;
        //            }
        //        }
        //
        //        protected void AddSupportActionBarEditButton()
        //        {
        //            if (_existsActionbar)
        //            {
        //                var editButton = FindViewById<ImageButton>(Resource.Id.actionEditGoal);
        //                editButton.Visibility = ViewStates.Visible;
        //                editButton.Click += editButtonClicked;
        //            }
        //        }
        //
        //        protected void RemoveSupportActionBarEditButton()
        //        {
        //            if (_existsActionbar)
        //            {
        //                var editButton = FindViewById<ImageButton>(Resource.Id.actionEditGoal);
        //                editButton.Visibility = ViewStates.Gone;
        //                editButton.Click -= editButtonClicked;
        //            }
        //        }
        //
        //        private void editButtonClicked(object sender, EventArgs e)
        //        {
        //            OnEditButtonClicked();
        //        }
        //
        //        protected virtual void OnEditButtonClicked()
        //        {
        //
        //        }
        //
        //        protected void AddSupportActionBarDuplicateButton()
        //        {
        //            addActionToSupportActionBar(Resource.Id.actionDuplicateGoal);
        //        }
        //
        //        protected void RemoveSupportActionBarDuplicateButton()
        //        {
        //            removeActionFromSupportActionBar(Resource.Id.actionDuplicateGoal);
        //        }
        //
        //
        //        private bool isSearchOpened()
        //        {
        //            return _existsActionbar && FindViewById<EditText>(Resource.Id.topToolbarSearchTxt).Visibility == ViewStates.Visible;
        //        }
        //
        //        private void actionSearchClicked(object sender, EventArgs e)
        //        {
        //            var actionSearch = FindViewById<ImageButton>(Resource.Id.actionSearch);
        //            if (isSearchOpened())
        //            {
        //                actionSearch.SetImageResource(Resource.Drawable.iczoominblack24dp);
        //                FindViewById<EditText>(Resource.Id.topToolbarSearchTxt).Visibility = ViewStates.Gone;
        //                if (_supportActionBarHasTitle)
        //                    this.AddSupportActionBarTitle(_pageTitle);
        //                if (_supportActionBarHasBackButton)
        //                    this.AddSupportActionBarBackButton();
        //
        //                OnSearchClosed();
        //            }
        //            else
        //            {
        //                actionSearch.SetImageResource(Resource.Drawable.iccloseblack24dp);
        //                FindViewById<EditText>(Resource.Id.topToolbarSearchTxt).Visibility = ViewStates.Visible;
        //                this.RemoveSupportActionBarTitle();
        //                this.RemoveSupportActionBarBackButton();
        //            }
        //        }
        //
        //        protected void RemoveSupportActionBarSearchFeature()
        //        {
        //            if (_existsActionbar)
        //            {
        //                var actionSearch = FindViewById<ImageButton>(Resource.Id.actionSearch);
        //                actionSearch.Visibility = ViewStates.Gone;
        //                actionSearch.Click -= actionSearchClicked;
        //                var searchTxt = FindViewById<EditText>(Resource.Id.topToolbarSearchTxt);
        //                searchTxt.EditorAction -= txtSearchEditorAction;
        //                searchTxt.Visibility = ViewStates.Gone;
        //            }
        //        }
        //
        //
        //
        //        private void txtSearchEditorAction(object sender, Android.Widget.TextView.EditorActionEventArgs e)
        //        {
        //            if (e.ActionId == ImeAction.Done
        //                || e.ActionId == ImeAction.Search
        //                ||
        //                (e.Event.Action == KeyEventActions.Down && e.Event.KeyCode == Keycode.Enter))
        //            {
        //                string text = ((TextView)sender).Text;
        //                OnDoSearch(text);
        //            }
        //        }
        //
        //        protected virtual void OnDoSearch(string searchText)
        //        {
        //
        //        }
        //
        //        protected virtual void OnSearchClosed()
        //        {
        //
        //        }
        //
        //        public void AddSupportActionBarCloseButton()
        //        {
        //            if (existsTopToolbar)
        //            {
        //                var closeButton = FindViewById<ImageButton>(Resource.Id.actionClose);
        //                closeButton.Visibility = ViewStates.Visible;
        //                closeButton.Click += closeButton_clicked;
        //
        //            }
        //        }
        //
        //        public void RemoveSupportActionBarCloseButton()
        //        {
        //            if (existsTopToolbar)
        //            {
        //                var closeButton = FindViewById<ImageButton>(Resource.Id.actionClose);
        //                closeButton.Visibility = ViewStates.Gone;
        //                closeButton.Click -= closeButton_clicked;
        //            }
        //        }
        //
        //        public void AddSupportActionBarBackButton()
        //        {
        //            if (existsTopToolbar)
        //            {
        //                var backButton = FindViewById<ImageButton>(Resource.Id.actionBackButton);
        //                backButton.Visibility = ViewStates.Visible;
        //                backButton.Click += backButtonClicked;
        //
        //            }
        //        }
        //
        //        private void closeButton_clicked(object sender, EventArgs e)
        //        {
        //            OnCloseClicked();
        //        }
        //
        //        protected virtual void OnCloseClicked()
        //        {
        //
        //        }
        //
        //        public void RemoveSupportActionBarBackButton()
        //        {
        //            if (_existsActionbar)
        //            {
        //                var backButton = FindViewById<ImageButton>(Resource.Id.actionBackButton);
        //                backButton.Visibility = ViewStates.Gone;
        //                backButton.Click -= backButtonClicked;
        //            }
        //
        //        }
        //
        //        public void RemoveAddGoalActionFromActionBar()
        //        {
        //            removeActionFromSupportActionBar(Resource.Id.actionAddGoals);
        //        }
        //
        //        public void RemoveUserSettingsActionFromActionBar()
        //        {
        //            removeActionFromSupportActionBar(Resource.Id.actionUsersettings);
        //        }
        //
        //        public void AddAddGoalActionFromActionBar()
        //        {
        //            addActionToSupportActionBar(Resource.Id.actionAddGoals);
        //        }
        //
        //        public void AddUserSettingsActionFromActionBar()
        //        {
        //            addActionToSupportActionBar(Resource.Id.actionUsersettings);
        //        }
        //
        //        public void HideBottonBar()
        //        {
        //            var bottomBar = this.FindViewById(BottomToolbarResourceId);
        //            if (!bottomBar.IsNull())
        //                bottomBar.Visibility = ViewStates.Gone;
        //        }
        //
        //        public void ShowBottonBar()
        //        {
        //            var bottomBar = this.FindViewById(BottomToolbarResourceId);
        //            if (!bottomBar.IsNull())
        //                bottomBar.Visibility = ViewStates.Visible;
        //        }
        //
        //        private void removeActionFromSupportActionBar(int actionResourceId)
        //        {
        //            if (existsTopToolbar)
        //            {
        //                var action = FindViewById(actionResourceId);
        //                if (!action.IsNull())
        //                    action.Visibility = ViewStates.Invisible;
        //            }
        //        }
        //
        //        /// <summary>
        //        /// Returns true if action was added
        //        /// </summary>
        //        /// <returns><c>true</c>, if action to support action bar was added, <c>false</c> otherwise.</returns>
        //        /// <param name="actionResourceId">Action resource identifier.</param>
        //        private bool addActionToSupportActionBar(int actionResourceId)
        //        {
        //            if (existsTopToolbar)
        //            {
        //                var action = FindViewById(actionResourceId);
        //                if (!action.IsNull())
        //                    action.Visibility = ViewStates.Visible;
        //            }
        //
        //            return existsTopToolbar;
        //        }
        //
        //        private void backButtonClicked(object sender, EventArgs e)
        //        {
        //            OnBackButtonClicked();
        //            if (CloseActivityOnBackButtonClicked)
        //                (this.ViewModel as BaseViewModel).BackCommand.Execute(null);
        //        }
        //
        //        protected virtual void OnBackButtonClicked()
        //        {
        //
        //        }
        //
        //
        //        protected void ShowToast(int resourceId)
        //        {
        //            var toast = Toast.MakeText(Android.App.Application.Context, resourceId, ToastLength.Short);
        //            toast.Show();
        //        }
        //
        //        protected void ShowConfirmDialog(int titleResourceId, Action okAction, Action cancelAction)
        //        {
        //            var b = new Android.App.AlertDialog.Builder(this);
        //            b.SetTitle(Resources.GetString(titleResourceId));
        //            b.SetPositiveButton(Resources.GetString(Resource.String.YesModalDialog), (object s, DialogClickEventArgs ev) =>
        //                {
        //                    if (okAction != null)
        //                        okAction();
        //                });
        //            b.SetNegativeButton(Resources.GetString(Resource.String.CancelModalDialog), (object s, DialogClickEventArgs ev) =>
        //                {
        //                    if (cancelAction != null)
        //                        cancelAction();
        //                });
        //            b.Show();
        //        }
    }
}

