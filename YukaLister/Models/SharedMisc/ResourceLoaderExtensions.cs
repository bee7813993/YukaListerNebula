// ============================================================================
//
// 言語リソースからの文字列取得（WPF 用スタブ）
// WPF では ResourceLoader が使用できないため、キー文字列をそのまま返す。
//
// ============================================================================

namespace Shinta;

internal static class ResourceLoaderExtensions
{
	public static String ToLocalized(this String resourceKey)
	{
		return resourceKey;
	}
}
