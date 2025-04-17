using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class ItemFieldData : Object
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x001081B0 File Offset: 0x001063B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFieldData()
		{
			Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr);
			ItemFieldData.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, "ItemID");
			ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr, 100668781);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x00108208 File Offset: 0x00106408
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData(string itemID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000193B6 File Offset: 0x000175B6
		public ItemFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x00108254 File Offset: 0x00106454
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x000193BF File Offset: 0x000175BF
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFieldData.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
