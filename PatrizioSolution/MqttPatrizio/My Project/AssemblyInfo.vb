Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' Le informazioni generali relative a un assembly sono controllate dal seguente 
' set di attributi. Modificare i valori di questi attributi per modificare le informazioni
' associate a un assembly.

' Rivedere i valori degli attributi degli assembly

<Assembly: AssemblyTitle("MqttPatrizio")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("MqttPatrizio")>
<Assembly: AssemblyCopyright("Copyright ©  2016")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'Per iniziare la compilazione delle applicazioni localizzabili, impostare 
'<UICulture>CultureYouAreCodingWith</UICulture> nel file VBPROJ
'all'interno di un <PropertyGroup>.  Ad esempio, se si utilizza l'inglese (Stati Uniti) 
'nei file di origine, impostare <UICulture> su "en-US".  Rimuovere quindi il commento
'dall'attributo NeutralResourceLanguage seguente.  Aggiornare "en-US" nella riga
'seguente in modo che corrisponda all'impostazione di UICulture nel file di progetto.

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)> 


'L'attributo ThemeInfo indica la possibile posizione dei dizionari risorse generici e specifici del tema.
'Primo parametro: posizione dei dizionari risorse specifici del tema
'(in uso se non è possibile trovare una risorsa nella pagina 
' oppure nei dizionari delle risorse dell'applicazione)

'Parametro 2: posizione del dizionario risorse generico
'(in uso se non è possibile trovare una risorsa nella pagina 
'un'applicazione e alcun dizionario risorse specifico del tema)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'Se il progetto viene esposto a COM, il GUID seguente verrà utilizzato come ID della libreria dei tipi
<Assembly: Guid("48a87c2f-4957-4d4e-8691-3eb004bffc27")>

' Le informazioni sulla versione di un assembly sono costituite dai seguenti quattro valori:
'
'      Versione principale
'      Versione secondaria 
'      Numero di build
'      Revisione
'
' È possibile specificare tutti i valori oppure impostare valori predefiniti per i numeri relativi alla revisione e alla build 
' usando l'asterisco '*' come illustrato di seguito:
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
