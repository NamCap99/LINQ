using System;
using System.Collections.Generic;
using System.Linq;
/*
Implement the CountFriendsOf method. This method takes the friend parameter and a collection of people. 
We want to count all those people, who have the friend amongst their friends.

For example, in this case, the result of the method should be 3 because there are 3 people who have friend in their Friends collection.
*/
namespace Coding.Exercise
{
    public class Contains_Exercise
    {
        public static int CountFriendsOf(Friend friend, IEnumerable<Person> people)
        {
            //TODO your code goes here
            return people.Count(p => p.Friends.Contains(friend));
        }
    }

    public class Person
    {
        public string Name { get; }
        public IEnumerable<Friend> Friends { get; }

        public Person(string name, IEnumerable<Friend> friends)
        {
            Name = name;
            Friends = friends;
        }
    }

    public class Friend
    {
        public string Name { get; }
    }
}
