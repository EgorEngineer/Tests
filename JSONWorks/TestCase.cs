using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat1.JSONWorks
{
    public class TestCase
    {
        public string Name { get; set; }                          
        public int[] Input { get; set; }                           
        public int ExpectedIndex { get; set; }                     
        public int ExpectedValue { get; set; }                     
        public long ExpectedSum { get; set; }                      
        public long ExpectedCube { get; set; }                     
        public int[] ExpectedTransformedArray { get; set; }        
        public List<string> ExpectedErrors { get; set; }           

        public int ActualIndex { get; set; }                       
        public int ActualValue { get; set; }                       
        public long ActualSum { get; set; }                        
        public long ActualCube { get; set; }                       
        public int[] ActualTransformedArray { get; set; }          
        public List<string> ActualErrors { get; set; }             
    }
}
