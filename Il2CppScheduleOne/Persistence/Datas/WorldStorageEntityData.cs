using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BF RID: 703
	[Serializable]
	public class WorldStorageEntityData : SaveData
	{
		// Token: 0x0600320B RID: 12811 RVA: 0x0010EF7C File Offset: 0x0010D17C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntityData()
		{
			Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "WorldStorageEntityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr);
			WorldStorageEntityData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "GUID");
			WorldStorageEntityData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, "Contents");
			WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr, 100668860);
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x0010EFE8 File Offset: 0x0010D1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131229, RefRangeEnd = 131230, XrefRangeStart = 131225, XrefRangeEnd = 131229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntityData(Guid guid, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntityData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntityData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x0001AD4F File Offset: 0x00018F4F
		public WorldStorageEntityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x0010F044 File Offset: 0x0010D244
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x0001AD58 File Offset: 0x00018F58
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0010F06C File Offset: 0x0010D26C
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0001AD77 File Offset: 0x00018F77
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntityData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400206E RID: 8302
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x0400206F RID: 8303
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemSet_0;
	}
}
