﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028F RID: 655
	[Serializable]
	public class EmployeeData : NPCData
	{
		// Token: 0x06003041 RID: 12353 RVA: 0x00109DA4 File Offset: 0x00107FA4
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeData()
		{
			Il2CppClassPointerStore<EmployeeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "EmployeeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr);
			EmployeeData.NativeFieldInfoPtr_AssignedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AssignedProperty");
			EmployeeData.NativeFieldInfoPtr_FirstName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "FirstName");
			EmployeeData.NativeFieldInfoPtr_LastName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "LastName");
			EmployeeData.NativeFieldInfoPtr_IsMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "IsMale");
			EmployeeData.NativeFieldInfoPtr_AppearanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "AppearanceIndex");
			EmployeeData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Position");
			EmployeeData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "Rotation");
			EmployeeData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "GUID");
			EmployeeData.NativeFieldInfoPtr_PaidForToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, "PaidForToday");
			EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr, 100668804);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00109E9C File Offset: 0x0010809C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130839, RefRangeEnd = 130840, XrefRangeStart = 130832, XrefRangeEnd = 130839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeData(string id, string assignedProperty, string firstName, string lastName, bool isMale, int appearanceIndex, Vector3 position, Quaternion rotation, Guid guid, bool paidForToday) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assignedProperty);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMale;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paidForToday;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000199ED File Offset: 0x00017BED
		public EmployeeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x00109F74 File Offset: 0x00108174
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x000199F6 File Offset: 0x00017BF6
		public unsafe string AssignedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AssignedProperty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x00109F9C File Offset: 0x0010819C
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x00019A15 File Offset: 0x00017C15
		public unsafe string FirstName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_FirstName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00109FC4 File Offset: 0x001081C4
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x00019A34 File Offset: 0x00017C34
		public unsafe string LastName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_LastName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x0600304A RID: 12362 RVA: 0x00109FEC File Offset: 0x001081EC
		// (set) Token: 0x0600304B RID: 12363 RVA: 0x00019A53 File Offset: 0x00017C53
		public unsafe bool IsMale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_IsMale)) = value;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x0010A014 File Offset: 0x00108214
		// (set) Token: 0x0600304D RID: 12365 RVA: 0x00019A6E File Offset: 0x00017C6E
		public unsafe int AppearanceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_AppearanceIndex)) = value;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x0010A03C File Offset: 0x0010823C
		// (set) Token: 0x0600304F RID: 12367 RVA: 0x00019A89 File Offset: 0x00017C89
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x0010A064 File Offset: 0x00108264
		// (set) Token: 0x06003051 RID: 12369 RVA: 0x00019AA4 File Offset: 0x00017CA4
		public unsafe Quaternion Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003052 RID: 12370 RVA: 0x0010A08C File Offset: 0x0010828C
		// (set) Token: 0x06003053 RID: 12371 RVA: 0x00019ABF File Offset: 0x00017CBF
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003054 RID: 12372 RVA: 0x0010A0B4 File Offset: 0x001082B4
		// (set) Token: 0x06003055 RID: 12373 RVA: 0x00019ADE File Offset: 0x00017CDE
		public unsafe bool PaidForToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeData.NativeFieldInfoPtr_PaidForToday)) = value;
			}
		}

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeFieldInfoPtr_AssignedProperty;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeFieldInfoPtr_FirstName;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeFieldInfoPtr_LastName;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeFieldInfoPtr_IsMale;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceIndex;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeFieldInfoPtr_PaidForToday;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Boolean_Int32_Vector3_Quaternion_Guid_Boolean_0;
	}
}
