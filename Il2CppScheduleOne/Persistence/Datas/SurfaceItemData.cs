using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A2 RID: 674
	[Serializable]
	public class SurfaceItemData : BuildableItemData
	{
		// Token: 0x06003100 RID: 12544 RVA: 0x0010C160 File Offset: 0x0010A360
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemData()
		{
			Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SurfaceItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr);
			SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "ParentSurfaceGUID");
			SurfaceItemData.NativeFieldInfoPtr_RelativePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativePosition");
			SurfaceItemData.NativeFieldInfoPtr_RelativeRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, "RelativeRotation");
			SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr, 100668823);
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x0010C1E0 File Offset: 0x0010A3E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130964, RefRangeEnd = 130965, XrefRangeStart = 130959, XrefRangeEnd = 130964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemData(Guid guid, ItemInstance item, int loadOrder, string parentSurfaceGUID, Vector3 pos, Quaternion rot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentSurfaceGUID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x0001A245 File Offset: 0x00018445
		public SurfaceItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x0010C278 File Offset: 0x0010A478
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x0001A24E File Offset: 0x0001844E
		public unsafe string ParentSurfaceGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_ParentSurfaceGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x0010C2A0 File Offset: 0x0010A4A0
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x0001A26D File Offset: 0x0001846D
		public unsafe Vector3 RelativePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativePosition)) = value;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x0010C2C8 File Offset: 0x0010A4C8
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x0001A288 File Offset: 0x00018488
		public unsafe Quaternion RelativeRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SurfaceItemData.NativeFieldInfoPtr_RelativeRotation)) = value;
			}
		}

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeFieldInfoPtr_ParentSurfaceGUID;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_RelativePosition;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeFieldInfoPtr_RelativeRotation;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_String_Vector3_Quaternion_0;
	}
}
