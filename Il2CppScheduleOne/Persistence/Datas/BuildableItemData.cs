using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000294 RID: 660
	[Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x0600307A RID: 12410 RVA: 0x0010A788 File Offset: 0x00108988
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemData()
		{
			Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BuildableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr);
			BuildableItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "GUID");
			BuildableItemData.NativeFieldInfoPtr_ItemString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "ItemString");
			BuildableItemData.NativeFieldInfoPtr_LoadOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "LoadOrder");
			BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, 100668809);
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0010A808 File Offset: 0x00108A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130871, RefRangeEnd = 130872, XrefRangeStart = 130867, XrefRangeEnd = 130871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData(Guid guid, ItemInstance item, int loadOrder) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00019C79 File Offset: 0x00017E79
		public BuildableItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x0010A870 File Offset: 0x00108A70
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x00019C82 File Offset: 0x00017E82
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x0010A898 File Offset: 0x00108A98
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x00019CA1 File Offset: 0x00017EA1
		public unsafe string ItemString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x0010A8C0 File Offset: 0x00108AC0
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x00019CC0 File Offset: 0x00017EC0
		public unsafe int LoadOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder)) = value;
			}
		}

		// Token: 0x04001FB7 RID: 8119
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001FB8 RID: 8120
		private static readonly IntPtr NativeFieldInfoPtr_ItemString;

		// Token: 0x04001FB9 RID: 8121
		private static readonly IntPtr NativeFieldInfoPtr_LoadOrder;

		// Token: 0x04001FBA RID: 8122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0;
	}
}
