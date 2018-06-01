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
		for( int i = 0; i < args.Length; i++ ) {
			// コマンドの取り出し
			string[] commandList = args[ i ].Split( ' ' );
			string subCommand = commandList[ 0 ];
			string target = commandList[ 1 ];

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
