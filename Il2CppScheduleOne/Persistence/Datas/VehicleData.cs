using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Vehicles.Modification;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BE RID: 702
	[Serializable]
	public class VehicleData : SaveData
	{
		// Token: 0x060031FE RID: 12798 RVA: 0x0010ED88 File Offset: 0x0010CF88
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleData()
		{
			Il2CppClassPointerStore<VehicleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VehicleData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleData>.NativeClassPtr);
			VehicleData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "GUID");
			VehicleData.NativeFieldInfoPtr_VehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "VehicleCode");
			VehicleData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Position");
			VehicleData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Rotation");
			VehicleData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, "Color");
			VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleData>.NativeClassPtr, 100668859);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0010EE30 File Offset: 0x0010D030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131224, RefRangeEnd = 131225, XrefRangeStart = 131216, XrefRangeEnd = 131224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleData(Guid guid, string code, Vector3 pos, Quaternion rot, EVehicleColor col) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleData.NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x0001ACB3 File Offset: 0x00018EB3
		public VehicleData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06003201 RID: 12801 RVA: 0x0010EEB4 File Offset: 0x0010D0B4
		// (set) Token: 0x06003202 RID: 12802 RVA: 0x0001ACBC File Offset: 0x00018EBC
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x06003203 RID: 12803 RVA: 0x0010EEDC File Offset: 0x0010D0DC
		// (set) Token: 0x06003204 RID: 12804 RVA: 0x0001ACDB File Offset: 0x00018EDB
		public unsafe string VehicleCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_VehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003205 RID: 12805 RVA: 0x0010EF04 File Offset: 0x0010D104
		// (set) Token: 0x06003206 RID: 12806 RVA: 0x0001ACFA File Offset: 0x00018EFA
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003207 RID: 12807 RVA: 0x0010EF2C File Offset: 0x0010D12C
		// (set) Token: 0x06003208 RID: 12808 RVA: 0x0001AD15 File Offset: 0x00018F15
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003209 RID: 12809 RVA: 0x0010EF54 File Offset: 0x0010D154
		// (set) Token: 0x0600320A RID: 12810 RVA: 0x0001AD30 File Offset: 0x00018F30
		public unsafe string Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleData.NativeFieldInfoPtr_Color), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeFieldInfoPtr_VehicleCode;

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_String_Vector3_Quaternion_EVehicleColor_0;
	}
}
