using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Based_Tree
{

    /// <summary>
    /// A Hash Table also called a Hash map is a data structure which implements an associative array that maps keys to values.
    /// A Hash Table uses a hash function to compute an index into an array of buckets or slots, from which the desired value can be found.
    /// Hash collision is a thing where they are not enough unique keys available for all potential keys.
    /// 
    /// In a well dimension hash table the average cost (number of instructions) for each lookup is independent of the number of elements stored in the table.
    /// On average more effieciant than a search tree or any other table lookup.
    /// 
    /// The idea of hashing is to distribute the entries (key/value pairs) across an array of buckets.
    /// index = f(key,array_size)
    /// 
    ///     Implement way to deal with Hash Collision
    ///     Seperate Chaining with :Linked List, List head cells
    ///     Open Addressing: Linear Probing, Quadratic probing, double hashing.
    ///         Problem with open addresing is that the number of stored entries cannot exceent the number of slots in the bucket array.
    ///         Must also minizume the clustering of hash values for probe order. Good for small, Bad for large datasets.
    ///     Coalesced Hashing: Hybrid between chaining and open adressing solution.
    ///     Cuckoo hashing: Uses multiple hashes.
    ///     Hopscotch hashing: Combines cuckoo hashing and linear probing
    ///     Robin Hood hashing: 
    ///     2-Choice hashing:
    ///     
    /// Dynamic Resizing: Good function of hash table needs the table size to be proportional to the number of entries.
    /// Advantages: Speed
    /// Drawbacks:
    /// Uses: Associative arrays, database indexing, caches, sets, object representation, unique data representation, transposition table.
    /// </summary>

    class HashTable
    {
        
        /// <summary>
        /// Constructor which initializes the HashTable with a given array size.
        /// </summary>
        /// <param name="newArraySize"></param>
        /// TO DO
        public HashTable(int newArraySize)
        {

        }

        //TO DO
        public void HashToTable()
        {
            /* The hash in independent of the array size and is then reduced using the modulo operator.
             */

            //Done in two steps
            //hash = hashfunc(key)
            //index = hash % array_size
            //Insert into table
        }
    }
}
