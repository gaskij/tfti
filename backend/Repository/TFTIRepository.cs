﻿using Kalandear.Data;
using System.Linq;
using System.Threading.Tasks;
using TFTI.Contracts;
using TFTI.Interfaces;

namespace TFTI.Repositories
{
    public class TFTIRepository : ITFTIRepository
    {
        public const string CONNECTION_NAME = "TFTIConnection";

        private TFTIContext _context;

        #region Constructor
        /// <summary>
        ///     Constructor to set the Kalandear database context.
        /// </summary>
        /// <param name="context"></param>
        public TFTIRepository(TFTIContext context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods

        #region Create Methods
        /// <inheritdoc/>
        public async Task<int> CreateUser(NewUser newUser)
        {
            User user = new User();
            user.first_name = newUser.first_name;
            user.last_name = newUser.last_name;
            user.email = newUser.email;
            user.pass_hash = newUser.pass_hash;
            user.salt = newUser.salt;
            user.phone_number = newUser.phone_number;
            user.user_summary = newUser.user_summary;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user.id;
        }
        
        /// <inheritdoc />
        public async Task<int> CreateEvent(NewEvent newEvent)
        {
            Event TFTIevent = new Event();
            TFTIevent.addtional_links = newEvent.addtional_links;
            TFTIevent.event_date = newEvent.event_date;
            TFTIevent.event_name = newEvent.event_name;
            TFTIevent.event_summary = newEvent.event_summary;
            TFTIevent.host_id = newEvent.host_id;
            TFTIevent.is_private = newEvent.is_private;
            TFTIevent.location = newEvent.location;

            _context.Events.Add(TFTIevent);
            await _context.SaveChangesAsync();

            return TFTIevent.event_id;
        }

        /// <inheritdoc />
        public async Task<EventAttendees> CreateEventAttendees(EventAttendees eventAttendees)
        {
            _context.EventAttendees.Add(eventAttendees);
            await _context.SaveChangesAsync();

            return eventAttendees;
        }

        /// <inheritdoc />
        public async Task<int> CreateEventInvites(NewEventInvites newEventInvites)
        {
            EventInvites eventInvite = new EventInvites();
            eventInvite.event_id = newEventInvites.event_id;
            eventInvite.accepted = newEventInvites.accepted;
            eventInvite.recipient_id = newEventInvites.recipient_id;
            eventInvite.sender_id = newEventInvites.sender_id;
            eventInvite.invite_time = newEventInvites.invite_time;

             _context.EventInvites.Add(eventInvite);
            await _context.SaveChangesAsync();
            return eventInvite.event_id;
        }

        /// <inheritdoc />
        public async Task<int> CreateFriend(Friend friend)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<int> CreateItem(NewItem newItem)
        {
            
            Item item = new Item();
            item.event_id = newItem.event_id;
            item.user_id= newItem.user_id;
            item.item_name = newItem.item_name;
            item.amount = newItem.amount;
            item.unit_type = newItem.unit_type;
     
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return item.item_id;

      
        }

        /// <inheritdoc />
        public async Task<int> CreateMedia(Media media)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<int> CreateMessage(NewMessage newMessage)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Update Methods
        /// <inheritdoc />
        public Task<User> UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Event> UpdateEvent(Event eventDetails)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<EventAttendees> UpdateEventAttendees(EventAttendees eventAttendees)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<EventInvites> UpdateEventInvites(EventInvites eventInvites)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Friend> UpdateFriend(Friend friend)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Item> UpdateItem(Item item)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Media> UpdateMedia(Media media)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Message> UpdateMessage(Message message)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Get Methods
        /// <inheritdoc />
        public Task<User> GetUser(int hostId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Event> GetEvent(int eventId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<CompleteEvent> GetCompleteEvent(int eventId)
        {
            CompleteEvent completeEvent = new CompleteEvent();

            completeEvent.EventDetails = _context.Events.Find(eventId);

            completeEvent.Attendees = _context.EventAttendees.Where(x => x.event_id == eventId).ToList();

            completeEvent.Items = _context.Items.Where(x => x.event_id == eventId).ToList();

            return completeEvent;
        }

        /// <inheritdoc />
        public Task<EventAttendees> GetEventAttendees(int eventAttendeesId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<EventInvites> GetEventInvites(int eventInvitesId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Friend> GetFriend(int friendId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Item> GetItem(int itemId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<Media> GetMedia(int mediaId)
        {
            throw new System.NotImplementedException();
        }
        /// <inheritdoc />
        public Task<Message> GetMessage(int messageId)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #endregion

        #region Private Methods
        #endregion
    }
}
