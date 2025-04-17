using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x0200075F RID: 1887
	public class StoredItem_Bin : StoredItem
	{
		// Token: 0x0600B369 RID: 45929 RVA: 0x002CBD98 File Offset: 0x002C9F98
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_Bin()
		{
			Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "StoredItem_Bin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr);
			StoredItem_Bin.NativeFieldInfoPtr_bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, "bin");
			StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr, 100685418);
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x002CBDF0 File Offset: 0x002C9FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_Bin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_Bin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_Bin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x00057EA1 File Offset: 0x000560A1
		public StoredItem_Bin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600B36C RID: 45932 RVA: 0x002CBE2C File Offset: 0x002CA02C
		// (set) Token: 0x0600B36D RID: 45933 RVA: 0x00057EAA File Offset: 0x000560AA
		public unsafe HandheldBin_Functional bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandheldBin_Functional>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_Bin.NativeFieldInfoPtr_bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007907 RID: 30983
		private static readonly IntPtr NativeFieldInfoPtr_bin;

		// Token: 0x04007908 RID: 30984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
