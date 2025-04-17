using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021A RID: 538
	public static class ItemDeserializer : Object
	{
		// Token: 0x06002CAD RID: 11437 RVA: 0x00018079 File Offset: 0x00016279
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDeserializer()
		{
			Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "ItemDeserializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr);
			ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr, 100668343);
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x000FE710 File Offset: 0x000FC910
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 124520, RefRangeEnd = 124543, XrefRangeStart = 124483, XrefRangeEnd = 124520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance LoadItem(string itemString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x000180B2 File Offset: 0x000162B2
		public ItemDeserializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0;
	}
}
