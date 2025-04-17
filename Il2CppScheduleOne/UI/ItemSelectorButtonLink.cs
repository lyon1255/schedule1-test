using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000646 RID: 1606
	public class ItemSelectorButtonLink : MonoBehaviour
	{
		// Token: 0x06008E27 RID: 36391 RVA: 0x0004456A File Offset: 0x0004276A
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelectorButtonLink()
		{
			Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSelectorButtonLink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr);
			ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr, 100680947);
		}

		// Token: 0x06008E28 RID: 36392 RVA: 0x0024FAEC File Offset: 0x0024DCEC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelectorButtonLink() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelectorButtonLink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelectorButtonLink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x000445A3 File Offset: 0x000427A3
		public ItemSelectorButtonLink(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006040 RID: 24640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
