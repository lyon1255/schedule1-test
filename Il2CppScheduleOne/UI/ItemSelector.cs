using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000645 RID: 1605
	public class ItemSelector : Singleton<ItemSelector>
	{
		// Token: 0x06008E24 RID: 36388 RVA: 0x00044528 File Offset: 0x00042728
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSelector()
		{
			Il2CppClassPointerStore<ItemSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr);
			ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr, 100680946);
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x0024FAB0 File Offset: 0x0024DCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258464, XrefRangeEnd = 258467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x00044561 File Offset: 0x00042761
		public ItemSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400603F RID: 24639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
