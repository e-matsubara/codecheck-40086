using System;
using System.Text;

public class MainApp {
	/// デコードコマンド
	private const string DECODE = "decode";
	/// エンコードコマンド
	private const string ENCODE = "encode";
	/// アラインコマンド
	private const string ALIGN = "align";

	static public void Main( string[] args ) {
		string line = Console.ReadLine();
		Console.WriteLine( line );
		Console.WriteLine( args[ 0 ] );
			// コマンドの取り出し
		string[] commandList = line.Split( ' ' );
		string subCommand = args[ 0 ];
		string target = args[ 1 ];

			switch( subCommand ) {
				case DECODE:
					Console.WriteLine( decode( target ) );
					break;
				case ENCODE:
					Console.WriteLine( encode( int.Parse( target ) ) );
					break;
				case ALIGN:
					break;
				default :
					break;
			}

	}

	/// <summary>
	/// デコード
	/// </summary>
	/// <param name="encodeStr">デコードしたい文.</param>
	private static int decode( string encodeStr ) {
		int result = 0;
		foreach( char c in encodeStr ) {
			result += ( ( int )c - 64 ) * 9 ^ ( encodeStr.Length - encodeStr.IndexOf( c ) );
		}
		return result;
	}

	/// <summary>
	/// エンコード
	/// </summary>
	/// <param name="encodeStr">エンコードしたい数値.</param>
	private static string encode( int decodeNum ) {
		string result = null;
		while( decodeNum > 0 ) {
			result = ( char )( decodeNum % 9 + 64 ) + result;
			decodeNum = ( decodeNum / 9 );
		}
		return result;
	}

	/// <summary>
	/// アライン
	/// </summary>
	/// <param name="encodeStr">アラインしたい文字列.</param>
	private static string align( string encodeStr ) {

		return string.Empty;
	}
}
