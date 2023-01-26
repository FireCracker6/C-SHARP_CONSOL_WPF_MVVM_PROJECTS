using System.Collections.ObjectModel;
using FluentAssertions;
using WPF_APP_CONTACTS_MVVM.MVVM.Models;
using WPF_APP_CONTACTS_MVVM.MVVM.ViewModels;
using WPF_APP_CONTACTS_MVVM.Services;

namespace WPF_APP.Tests
{
    public class ContactsViewModel_Tests
    {

        private ContactsViewModel viewModel;
        

        public ContactsViewModel_Tests()
        {
            viewModel= new ContactsViewModel();
        }

        [Fact]
        public void Should_Add_Artist_To_ArtistList()
        {   // act
            ContactModel artist = new ContactModel { ArtistName = "Ozzy Osbourne", Associates = "Ozzy", RecordLabel = "Epic Records", ArtistSongs = "The Ultimate Sin" };
            viewModel.Contacts.Add(artist);
            // assert
            viewModel.Contacts.Should().BeOfType<ObservableCollection<ContactModel>>();
            viewModel.Contacts.Should().Contain(artist);
        }
    }
}