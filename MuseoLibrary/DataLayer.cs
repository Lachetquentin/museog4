using NPoco;
using System;
using System.Collections.Generic;

namespace MuseoLibrary
{
    public static class DataLayer
    {
        public static IDatabase s_db = new Database(new MySql.Data.MySqlClient.MySqlConnection(Properties.Resources.ConnString));
        public static class ArtistData
        {
            public static void AddArtist(string name, DateTime dob, string desc, string url, string isni)
            {
                try
                {
                    s_db.Connection.Open();
                    Artist artist = new()
                    {
                        Name = name,
                        Dob = dob.Date.ToLocalTime(),
                        Desc = desc,
                        URL = url,
                        Isni = isni
                    };
                    s_db.Insert(artist);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfArtistExists(int selectedArtistId)
            {
                bool artistFound = false;
                Artist artist = new();

                artist = GetArtistById(selectedArtistId);

                return artist != null ? (artistFound = true) : artistFound;
            }

            public static bool DeleteArtist(int selectedArtistId)
            {
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<Artist>(selectedArtistId);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }

            public static List<Artist> GetAllArtists()
            {
                List<Artist> listofArtists = new();

                try
                {
                    s_db.Connection.Open();
                    listofArtists = s_db.Fetch<Artist>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofArtists;
            }

            public static Artist GetArtistById(int artistId)
            {
                Artist artist = new();

                try
                {
                    s_db.Connection.Open();
                    artist = s_db.Query<Artist>().Where(a => a.ArtistId == artistId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return artist;
            }

            public static Artist GetArtistByName(string name)
            {
                Artist artist = new();

                try
                {
                    s_db.Connection.Open();
                    artist = s_db.Query<Artist>().Where(a => a.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return artist;
            }

            public static List<Artist> SearchArtists(string name)
            {
                List<Artist> listofArtists = new();

                Artist artist = new();

                artist = GetArtistByName(name);

                if (artist != null)
                {
                    listofArtists.Add(artist);
                    return listofArtists;
                }

                try
                {
                    s_db.Connection.Open();
                    listofArtists = s_db.Fetch<Artist>("where name LIKE %@name%", name);
                    return listofArtists;
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofArtists;
            }

            public static bool UpdateArtist(int artistId, string name, DateTime dob, string desc, string url, string isni)
            {
                try
                {
                    s_db.Connection.Open();
                    Artist artist = s_db.SingleById<Artist>(artistId);
                    artist.Name = name;
                    artist.Dob = dob.Date.ToLocalTime();
                    artist.Desc = desc;
                    artist.URL = url;
                    artist.Isni = isni;
                    s_db.Update(artist);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }
        }
        public static class ExhibitionData
        {
            public static void AddExhibition(string name)
            {
                try
                {
                    s_db.Connection.Open();
                    Exhibition exhibition = new()
                    {
                        Name = name
                    };
                    s_db.Insert(exhibition);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfExhibitionExists(int selectedExhibitionId)
            {
                bool exhibitionFound = false;
                Exhibition exhibition = new();

                exhibition = GetExhibitionById(selectedExhibitionId);

                return exhibition != null ? (exhibitionFound = true) : exhibitionFound;
            }

            public static bool DeleteExhibition(int selectedExhibitionId)
            {
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<Exhibition>(selectedExhibitionId);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }

            public static List<Exhibition> GetAllExhibitions()
            {
                List<Exhibition> exhibitions = new();

                try
                {
                    s_db.Connection.Open();
                    exhibitions = s_db.Fetch<Exhibition>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return exhibitions;
            }

            public static Exhibition GetExhibitionById(int exhibitionId)
            {
                Exhibition exhibition = new();

                try
                {
                    s_db.Connection.Open();
                    exhibition = s_db.Query<Exhibition>().Where(e => e.ExhibitionId == exhibitionId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return exhibition;
            }

            public static Exhibition GetExhibitionByName(string name)
            {
                Exhibition exhibition = new();

                try
                {
                    s_db.Connection.Open();
                    exhibition = s_db.Query<Exhibition>().Where(e => e.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return exhibition;
            }

            public static bool UpdateExhibition(int exhibitionId, string name)
            {
                try
                {
                    s_db.Connection.Open();
                    var exhibition = s_db.SingleById<Exhibition>(exhibitionId);
                    exhibition.Name = name;
                    s_db.Update(exhibition);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }
        };
        public static class LocationData
        {
            public static bool CheckIfLocationExists(int selectedLocationId)
            {
                bool locationFound = false;
                Location location = new();

                location = GetLocationById(selectedLocationId);

                return location != null ? (locationFound = true) : locationFound;
            }

            public static List<Location> GetAllLocations()
            {
                List<Location> locations = new();

                try
                {
                    s_db.Connection.Open();
                    locations = s_db.Fetch<Location>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return locations;
            }

            public static Location GetLocationById(int locationId)
            {
                Location location = new();

                try
                {
                    s_db.Connection.Open();
                    location = s_db.Query<Location>().Where(l => l.LocationId == locationId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return location;
            }

            public static Location GetLocationByName(string name)
            {
                Location location = new();

                try
                {
                    s_db.Connection.Open();
                    location = s_db.Query<Location>().Where(l => l.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return location;
            }

            public static bool UpdateLocation(int locationId, string name)
            {
                try
                {
                    s_db.Connection.Open();
                    var location = s_db.SingleById<Location>(locationId);
                    location.Name = name;
                    s_db.Update(location);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }
        };
        public static class MasterpieceData
        {
            public static void AddMasterpiece(int artistId, int exhibitionId, int stateId, int statusId, int locationId, int ownerId, string name, int createYear, string desc, string memo, string url, string ncda)
            {
                try
                {
                    s_db.Connection.Open();
                    Masterpiece masterpiece = new()
                    {
                        ArtistId = artistId,
                        ExhibitionId = exhibitionId,
                        StateId = stateId,
                        StatusId = statusId,
                        LocationId = locationId,
                        OwnerId = ownerId,
                        Name = name,
                        CreateYear = createYear,
                        Desc = desc,
                        Memo = memo,
                        URL = url,
                        Ncda = ncda
                    };
                    s_db.Insert(masterpiece);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfMasterpieceExists(int selectedMasterpieceId)
            {
                bool masterpieceFound = false;
                Masterpiece mp = new();

                mp = GetMasterpieceById(selectedMasterpieceId);

                return mp != null ? (masterpieceFound = true) : masterpieceFound;
            }

            public static void DeleteMasterpiece(int selectedMasterpieceId)
            {
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<Masterpiece>(selectedMasterpieceId);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static List<Masterpiece> GetAllMasterpieces()
            {
                List<Masterpiece> listofMasterpieces = new();

                try
                {
                    s_db.Connection.Open();
                    listofMasterpieces = s_db.Fetch<Masterpiece>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofMasterpieces;
            }

            public static object GetListOfMasterpiecesByArtistId(int artistId)
            {
                List<Masterpiece> listofMasterpieces = new();

                try
                {
                    s_db.Connection.Open();
                    listofMasterpieces = s_db.Query<Masterpiece>().Where(m => m.ArtistId == artistId).ToList();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofMasterpieces;
            }

            public static object GetListOfMasterpiecesByExhibitionId(int exhibitionId)
            {
                List<Masterpiece> listofMasterpieces = new();

                try
                {
                    s_db.Connection.Open();
                    listofMasterpieces = s_db.Query<Masterpiece>().Where(m => m.ExhibitionId == exhibitionId).ToList();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofMasterpieces;
            }

            public static List<Masterpiece> GetListOfMasterpiecesByOwnerId(int ownerId)
            {
                List<Masterpiece> listofMasterpieces = new();

                try
                {
                    s_db.Connection.Open();
                    listofMasterpieces = s_db.Query<Masterpiece>().Where(m => m.OwnerId == ownerId).ToList();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofMasterpieces;
            }

            public static Masterpiece GetMasterpieceById(int masterpieceId)
            {
                Masterpiece mp = new();

                try
                {
                    s_db.Connection.Open();
                    mp = s_db.Query<Masterpiece>().Where(m => m.MasterpieceId == masterpieceId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return mp;
            }

            public static Masterpiece GetMasterpieceByName(string name)
            {
                Masterpiece mp = new();

                try
                {
                    s_db.Connection.Open();
                    mp = s_db.Query<Masterpiece>().Where(m => m.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return mp;
            }

            public static List<Masterpiece> SearchMasterpieces(string name)
            {
                List<Masterpiece> listofMasterpieces = new();

                Masterpiece mp = new();

                mp = GetMasterpieceByName(name);

                if (mp != null)
                {
                    listofMasterpieces.Add(mp);
                    return listofMasterpieces;
                }

                try
                {
                    s_db.Connection.Open();
                    listofMasterpieces = s_db.Fetch<Masterpiece>("where name LIKE %@name%", name);
                    return listofMasterpieces;
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofMasterpieces;
            }

            public static bool UpdateMasterpiece(int masterpieceId, Artist artist, Exhibition exhibition, MpState state, MpStatus status, Location location, Owner owner, string name, int createYear, string desc, string memo, string url, string ncda)
            {
                try
                {
                    s_db.Connection.Open();
                    Masterpiece mp = s_db.SingleById<Masterpiece>(masterpieceId);
                    mp.ArtistId = artist.ArtistId;
                    mp.ExhibitionId = exhibition.ExhibitionId;
                    mp.StateId = state.StateId;
                    mp.StatusId = status.StatusId;
                    mp.LocationId = location.LocationId;
                    mp.OwnerId = owner.OwnerId;
                    mp.Name = name;
                    mp.CreateYear = createYear;
                    mp.Desc = desc;
                    mp.Memo = memo;
                    mp.URL = url;
                    mp.Ncda = ncda;
                    s_db.Update(mp);
                    return true;
                }
                catch (Exception) { return false;  }
                finally { s_db.Connection.Close(); }
            }
        }        
        public static class MpStateData
        {
            public static void AddState(string name)
            {
                try
                {
                    s_db.Connection.Open();
                    MpState state = new()
                    {
                        Name = name
                    };
                    s_db.Insert(state);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfStateExists(int selectedStateId)
            {
                bool stateFound = false;
                MpState state = new();

                state = GetStateById(selectedStateId);

                return state != null ? (stateFound = true) : stateFound;
            }

            public static bool DeleteState(int selectedStateId)
            {
                bool success = false;
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<MpState>(selectedStateId);
                    success = true;
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return success;
            }

            public static List<MpState> GetAllStates()
            {
                List<MpState> listOfStates = new();

                try
                {
                    s_db.Connection.Open();
                    listOfStates = s_db.Fetch<MpState>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listOfStates;
            }

            public static MpState GetStateById(int stateId)
            {
                MpState state = new();

                try
                {
                    s_db.Connection.Open();
                    state = s_db.Query<MpState>().Where(s => s.StateId == stateId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return state;
            }

            public static MpState GetStateByName(string name)
            {
                MpState state = new();

                try
                {
                    s_db.Connection.Open();
                    state = s_db.Query<MpState>().Where(s => s.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return state;
            }

            public static bool UpdateState(int stateId, string name)
            {
                try
                {
                    s_db.Connection.Open();
                    var state = s_db.SingleById<MpState>(stateId);
                    state.Name = name;
                    s_db.Update(state);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }
        }
        public static class MpStatusData
        {
            public static void AddStatus(string name)
            {
                try
                {
                    s_db.Connection.Open();
                    MpStatus status = new()
                    {
                        Name = name
                    };
                    s_db.Insert(status);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfStatusExists(int selectedStatusId)
            {
                bool statusFound = false;
                MpStatus status = new();

                status = GetStatusById(selectedStatusId);

                return status != null ? (statusFound = true) : statusFound;
            }

            public static bool DeleteStatus(int selectedStatusId)
            {
                bool success = false;
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<MpStatus>(selectedStatusId);
                    success = true;
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return success;
            }

            public static List<MpStatus> GetAllStatus()
            {
                List<MpStatus> listOfStatus = new();

                try
                {
                    s_db.Connection.Open();
                    listOfStatus = s_db.Fetch<MpStatus>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listOfStatus;
            }

            public static MpStatus GetStatusById(int statusId)
            {
                MpStatus status = new();

                try
                {
                    s_db.Connection.Open();
                    status = s_db.Query<MpStatus>().Where(s => s.StatusId == statusId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return status;
            }

            public static MpStatus GetStatusByName(string name)
            {
                MpStatus status = new();

                try
                {
                    s_db.Connection.Open();
                    status = s_db.Query<MpStatus>().Where(s => s.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return status;
            }

            public static bool UpdateStatus(int statusId, string name)
            {
                try
                {
                    s_db.Connection.Open();
                    var status = s_db.SingleById<MpStatus>(statusId);
                    status.Name = name;
                    s_db.Update(status);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }
        };
        public static class OwnerData
        {
            public static void AddOwner(string location, string name, string email, string phoneNumber)
            {
                try
                {
                    s_db.Connection.Open();
                    Owner owner = new()
                    {
                        Location = location,
                        Name = name,
                        Email = email,
                        PhoneNumber = phoneNumber
                    };
                    s_db.Insert(owner);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfOwnerExists(int selectedOwnerId)
            {
                bool ownerFound = false;
                Owner owner = new();

                owner = GetOwnerById(selectedOwnerId);

                return owner != null ? (ownerFound = true) : ownerFound;
            }

            public static bool DeleteOwner(int selectedOwnerId)
            {
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<Owner>(selectedOwnerId);
                    return true;
                }
                catch (Exception) { return false; }
                finally { s_db.Connection.Close(); }
            }

            public static List<Owner> GetAllOwners()
            {
                List<Owner> listOfOwners = new();

                try
                {
                    s_db.Connection.Open();
                    listOfOwners = s_db.Fetch<Owner>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listOfOwners;
            }

            public static Owner GetOwnerById(int ownerId)
            {
                Owner owner = new();

                try
                {
                    s_db.Connection.Open();
                    owner = s_db.Query<Owner>().Where(o => o.OwnerId == ownerId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return owner;
            }

            public static Owner GetOwnerByName(string name)
            {
                Owner owner = new();

                try
                {
                    s_db.Connection.Open();
                    owner = s_db.Query<Owner>().Where(o => o.Name == name).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return owner;
            }

            public static void UpdateOwner(int ownerId, string location, string name, string email, string phoneNumber)
            {
                try
                {
                    s_db.Connection.Open();
                    Owner owner = s_db.SingleById<Owner>(ownerId);
                    owner.Location = location;
                    owner.Name = name;
                    owner.Email = email;
                    owner.PhoneNumber = phoneNumber;
                    s_db.Update(owner);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }
        };
        public static class UserData
        {
            public static void AddUser(string username, string password)
            {
                try
                {
                    s_db.Connection.Open();
                    User u = new User() { Username = username, RoleId = 1, Email = "", Password = Utils.EncryptPassword(password) };
                    s_db.Insert(u);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static bool CheckIfUserExists(int selectedUserId)
            {
                bool userFound = false;
                User user = new();

                user = GetUserById(selectedUserId);


                return user != null ? (userFound = true) : userFound;
            }

            public static void DeleteUser(int selectedUserId)
            {
                try
                {
                    s_db.Connection.Open();
                    s_db.Delete<User>(selectedUserId);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }

            public static List<User> GetAllUsers()
            {
                List<User> listofUsers = new();

                try
                {
                    s_db.Connection.Open();
                    listofUsers = s_db.Fetch<User>();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return listofUsers;
            }

            public static User GetUserById(int userId)
            {
                User user = new();

                try
                {
                    s_db.Connection.Open();
                    user = s_db.Query<User>().Where(u => u.UserId == userId).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return user;
            }

            public static User GetUserByUsername(string username)
            {
                User user = new();

                try
                {
                    s_db.Connection.Open();
                    user = s_db.Query<User>().Where(u => u.Username == username).SingleOrDefault();
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }

                return user;
            }

            public static void UpdateUser(int userId, string username, string password)
            {
                try
                {
                    s_db.Connection.Open();
                    var user = s_db.SingleById<User>(userId);
                    user.Username = username;
                    user.Password = Utils.EncryptPassword(password);
                    s_db.Update(user);
                }
                catch (Exception) { }
                finally { s_db.Connection.Close(); }
            }
        }
    }
}
