﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpGL;

namespace IObjFormatConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("prismoid");
                var prismoid = new PrismoidModel(5, 5, 6, 6, 2);
                var filename = "prismoid.obj_";
                prismoid.DumpObjFile(filename, "prismoid");
                var parser = new ObjVNFParser(false);
                ObjVNFResult result = parser.Parse(filename);
                if (result.Error != null)
                {
                    Console.WriteLine("Error: {0}", result.Error);
                }
                else
                {
                    ObjVNFMesh mesh = result.Mesh;
                    var model = new ObjVNF(mesh);
                    model.DumpObjFile("vnf" + filename, "prismoid");
                }
            }
            {
                Console.WriteLine("cylinder");
                var cylinder = new CylinderModel(0.5f, 6, 17);
                var filename = "cylinder.obj_";
                cylinder.DumpObjFile(filename, "cylinder");
                var parser = new ObjVNFParser(false);
                ObjVNFResult result = parser.Parse(filename);
                if (result.Error != null)
                {
                    Console.WriteLine("Error: {0}", result.Error);
                }
                else
                {
                    ObjVNFMesh mesh = result.Mesh;
                    var model = new ObjVNF(mesh);
                    model.DumpObjFile("vnf" + filename, "cylinder");
                }
            }

            {
                Console.WriteLine("annulus");
                var annulus = new AnnulusModel(0.5f + 0.4f, 0.3f, 17, 17);
                var filename = "annulus.obj_";
                annulus.DumpObjFile(filename, "annulus");
                var parser = new ObjVNFParser(false);
                ObjVNFResult result = parser.Parse(filename);
                if (result.Error != null)
                {
                    Console.WriteLine("Error: {0}", result.Error);
                }
                else
                {
                    ObjVNFMesh mesh = result.Mesh;
                    var model = new ObjVNF(mesh);
                    model.DumpObjFile("vnf" + filename, "annulus");
                }
            }
            Console.WriteLine("done");
        }
    }
}
