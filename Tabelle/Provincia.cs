﻿using System.Resources;

namespace FatturaElettronica.Tabelle
{
    /// <summary>
    /// Attualmente non usata in convalida, vedo:
    /// https://github.com/FatturaElettronica/FatturaElettronica.NET/issues/129
    /// /// </summary>
    public class Provincia : Tabella
    {
        public override Tabella[] List
        {
            get
            {
                return new Tabella[]
                {
                    new Provincia { Codice = "AG", Nome = "Agrigento" },
                    new Provincia { Codice = "AL", Nome = "Alessandria" },
                    new Provincia { Codice = "AN", Nome = "Ancona" },
                    new Provincia { Codice = "AO", Nome = "Aosta" },
                    new Provincia { Codice = "AQ", Nome = "L'Aquila" },
                    new Provincia { Codice = "AR", Nome = "Arezzo" },
                    new Provincia { Codice = "AP", Nome = "Ascoli-Piceno" },
                    new Provincia { Codice = "AT", Nome = "Asti" },
                    new Provincia { Codice = "AV", Nome = "Avellino" },
                    new Provincia { Codice = "BA", Nome = "Bari" },
                    new Provincia { Codice = "BT", Nome = "Barletta-Andria-Trani" },
                    new Provincia { Codice = "BL", Nome = "Belluno" },
                    new Provincia { Codice = "BN", Nome = "Benevento" },
                    new Provincia { Codice = "BG", Nome = "Bergamo" },
                    new Provincia { Codice = "BI", Nome = "Biella" },
                    new Provincia { Codice = "BO", Nome = "Bologna" },
                    new Provincia { Codice = "BZ", Nome = "Bolzano" },
                    new Provincia { Codice = "BS", Nome = "Brescia" },
                    new Provincia { Codice = "BR", Nome = "Brindisi" },
                    new Provincia { Codice = "CA", Nome = "Cagliari" },
                    new Provincia { Codice = "CL", Nome = "Caltanissetta" },
                    new Provincia { Codice = "CB", Nome = "Campobasso" },
                    new Provincia { Codice = "CI", Nome = "Carbonia Iglesias" },
                    new Provincia { Codice = "CE", Nome = "Caserta" },
                    new Provincia { Codice = "CT", Nome = "Catania" },
                    new Provincia { Codice = "CZ", Nome = "Catanzaro" },
                    new Provincia { Codice = "CH", Nome = "Chieti" },
                    new Provincia { Codice = "CO", Nome = "Como" },
                    new Provincia { Codice = "CS", Nome = "Cosenza" },
                    new Provincia { Codice = "CR", Nome = "Cremona" },
                    new Provincia { Codice = "KR", Nome = "Crotone" },
                    new Provincia { Codice = "CN", Nome = "Cuneo" },
                    new Provincia { Codice = "EN", Nome = "Enna" },
                    new Provincia { Codice = "FM", Nome = "Fermo" },
                    new Provincia { Codice = "FE", Nome = "Ferrara" },
                    new Provincia { Codice = "FI", Nome = "Firenze" },
                    new Provincia { Codice = "FG", Nome = "Foggia" },
                    new Provincia { Codice = "FC", Nome = "Forli-Cesena" },
                    new Provincia { Codice = "FR", Nome = "Frosinone" },
                    new Provincia { Codice = "GE", Nome = "Genova" },
                    new Provincia { Codice = "GO", Nome = "Gorizia" },
                    new Provincia { Codice = "GR", Nome = "Grosseto" },
                    new Provincia { Codice = "IM", Nome = "Imperia" },
                    new Provincia { Codice = "IS", Nome = "Isernia" },
                    new Provincia { Codice = "SP", Nome = "La-Spezia" },
                    new Provincia { Codice = "LT", Nome = "Latina" },
                    new Provincia { Codice = "LE", Nome = "Lecce" },
                    new Provincia { Codice = "LC", Nome = "Lecco" },
                    new Provincia { Codice = "LI", Nome = "Livorno" },
                    new Provincia { Codice = "LO", Nome = "Lodi" },
                    new Provincia { Codice = "LU", Nome = "Lucca" },
                    new Provincia { Codice = "MC", Nome = "Macerata" },
                    new Provincia { Codice = "MN", Nome = "Mantova" },
                    new Provincia { Codice = "MS", Nome = "Massa-Carrara" },
                    new Provincia { Codice = "MT", Nome = "Matera" },
                    new Provincia { Codice = "VS", Nome = "Medio Campidano" },
                    new Provincia { Codice = "ME", Nome = "Messina" },
                    new Provincia { Codice = "MI", Nome = "Milano" },
                    new Provincia { Codice = "MO", Nome = "Modena" },
                    new Provincia { Codice = "MB", Nome = "Monza-Brianza" },
                    new Provincia { Codice = "NA", Nome = "Napoli" },
                    new Provincia { Codice = "NO", Nome = "Novara" },
                    new Provincia { Codice = "NU", Nome = "Nuoro" },
                    new Provincia { Codice = "OG", Nome = "Ogliastra" },
                    new Provincia { Codice = "OT", Nome = "Olbia Tempio" },
                    new Provincia { Codice = "OR", Nome = "Oristano" },
                    new Provincia { Codice = "PD", Nome = "Padova" },
                    new Provincia { Codice = "PA", Nome = "Palermo" },
                    new Provincia { Codice = "PR", Nome = "Parma" },
                    new Provincia { Codice = "PV", Nome = "Pavia" },
                    new Provincia { Codice = "PG", Nome = "Perugia" },
                    new Provincia { Codice = "PU", Nome = "Pesaro-Urbino" },
                    new Provincia { Codice = "PE", Nome = "Pescara" },
                    new Provincia { Codice = "PC", Nome = "Piacenza" },
                    new Provincia { Codice = "PI", Nome = "Pisa" },
                    new Provincia { Codice = "PT", Nome = "Pistoia" },
                    new Provincia { Codice = "PN", Nome = "Pordenone" },
                    new Provincia { Codice = "PZ", Nome = "Potenza" },
                    new Provincia { Codice = "PO", Nome = "Prato" },
                    new Provincia { Codice = "RG", Nome = "Ragusa" },
                    new Provincia { Codice = "RA", Nome = "Ravenna" },
                    new Provincia { Codice = "RC", Nome = "Reggio-Calabria" },
                    new Provincia { Codice = "RE", Nome = "Reggio-Emilia" },
                    new Provincia { Codice = "RI", Nome = "Rieti" },
                    new Provincia { Codice = "RN", Nome = "Rimini" },
                    new Provincia { Codice = "RM", Nome = "Roma" },
                    new Provincia { Codice = "RO", Nome = "Rovigo" },
                    new Provincia { Codice = "SA", Nome = "Salerno" },
                    new Provincia { Codice = "SS", Nome = "Sassari" },
                    new Provincia { Codice = "SV", Nome = "Savona" },
                    new Provincia { Codice = "SI", Nome = "Siena" },
                    new Provincia { Codice = "SR", Nome = "Siracusa" },
                    new Provincia { Codice = "SO", Nome = "Sondrio" },
                    new Provincia { Codice = "SU", Nome = "Sud Sardegna" },
                    new Provincia { Codice = "TA", Nome = "Taranto" },
                    new Provincia { Codice = "TE", Nome = "Teramo" },
                    new Provincia { Codice = "TR", Nome = "Terni" },
                    new Provincia { Codice = "TO", Nome = "Torino" },
                    new Provincia { Codice = "TP", Nome = "Trapani" },
                    new Provincia { Codice = "TN", Nome = "Trento" },
                    new Provincia { Codice = "TV", Nome = "Treviso" },
                    new Provincia { Codice = "TS", Nome = "Trieste" },
                    new Provincia { Codice = "UD", Nome = "Udine" },
                    new Provincia { Codice = "VA", Nome = "Varese" },
                    new Provincia { Codice = "VE", Nome = "Venezia" },
                    new Provincia { Codice = "VB", Nome = "Verbania" },
                    new Provincia { Codice = "VC", Nome = "Vercelli" },
                    new Provincia { Codice = "VR", Nome = "Verona" },
                    new Provincia { Codice = "VV", Nome = "Vibo-Valentia" },
                    new Provincia { Codice = "VI", Nome = "Vicenza" },
                    new Provincia { Codice = "VT", Nome = "Viterbo"}
                };
            }
        }
    }
    
    public class ProvinciaV2 : TabellaV2<ProvinciaV2>
    {
        protected override ResourceManager ResourceManager => Resources.Provincia.ResourceManager;
    }
}
