using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class MoveItemData : Object
	{
		// Token: 0x06003056 RID: 12374 RVA: 0x0010A0DC File Offset: 0x001082DC
		// Note: this type is marked as 'beforefieldinit'.
		static MoveItemData()
		{
			Il2CppClassPointerStore<MoveItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MoveItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr);
			MoveItemData.NativeFieldInfoPtr_TemplateItemJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "TemplateItemJSON");
			MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "GrabbedItemQuantity");
			MoveItemData.NativeFieldInfoPtr_SourceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "SourceGUID");
			MoveItemData.NativeFieldInfoPtr_DestinationGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, "DestinationGUID");
			MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr, 100668805);
		}

		// Token: 0x06003057 RID: 12375 RVA: 0x0010A170 File Offset: 0x00108370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130849, RefRangeEnd = 130850, XrefRangeStart = 130840, XrefRangeEnd = 130849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveItemData(string templateItemJson, int grabbedItemQuantity, Guid sourceGUID, Guid destinationGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(templateItemJson);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref grabbedItemQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceGUID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationGUID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x00019AF9 File Offset: 0x00017CF9
		public MoveItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x0010A1E8 File Offset: 0x001083E8
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x00019B02 File Offset: 0x00017D02
		public unsafe string TemplateItemJSON
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_TemplateItemJSON), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x0010A210 File Offset: 0x00108410
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x00019B21 File Offset: 0x00017D21
		public unsafe int GrabbedItemQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_GrabbedItemQuantity)) = value;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x0010A238 File Offset: 0x00108438
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x00019B3C File Offset: 0x00017D3C
		public unsafe string SourceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_SourceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x0010A260 File Offset: 0x00108460
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x00019B5B File Offset: 0x00017D5B
		public unsafe string DestinationGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveItemData.NativeFieldInfoPtr_DestinationGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeFieldInfoPtr_TemplateItemJSON;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeFieldInfoPtr_GrabbedItemQuantity;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeFieldInfoPtr_SourceGUID;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeFieldInfoPtr_DestinationGUID;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Guid_Guid_0;
	}
}
