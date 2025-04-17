using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000796 RID: 1942
	[Serializable]
	public class VolumeEffectField : Il2CppSystem.Object
	{
		// Token: 0x0600B7DF RID: 47071 RVA: 0x002DA15C File Offset: 0x002D835C
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectField()
		{
			Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr);
			VolumeEffectField.NativeFieldInfoPtr_fieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "fieldName");
			VolumeEffectField.NativeFieldInfoPtr_fieldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "fieldType");
			VolumeEffectField.NativeFieldInfoPtr_valueSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueSingle");
			VolumeEffectField.NativeFieldInfoPtr_valueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueColor");
			VolumeEffectField.NativeFieldInfoPtr_valueBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueBoolean");
			VolumeEffectField.NativeFieldInfoPtr_valueVector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector2");
			VolumeEffectField.NativeFieldInfoPtr_valueVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector3");
			VolumeEffectField.NativeFieldInfoPtr_valueVector4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, "valueVector4");
			VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685884);
			VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685885);
			VolumeEffectField.NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685886);
			VolumeEffectField.NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr, 100685887);
		}

		// Token: 0x0600B7E0 RID: 47072 RVA: 0x002DA27C File Offset: 0x002D847C
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110661, RefRangeEnd = 110710, XrefRangeStart = 110661, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField(string fieldName, string fieldType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fieldType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E1 RID: 47073 RVA: 0x002DA2DC File Offset: 0x002D84DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312589, RefRangeEnd = 312593, XrefRangeStart = 312584, XrefRangeEnd = 312589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField(FieldInfo pi, Component c) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E2 RID: 47074 RVA: 0x002DA33C File Offset: 0x002D853C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 312611, RefRangeEnd = 312620, XrefRangeStart = 312593, XrefRangeEnd = 312611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValidType(string type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x002DA380 File Offset: 0x002D8580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312636, RefRangeEnd = 312637, XrefRangeStart = 312620, XrefRangeEnd = 312636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue(Il2CppSystem.Object val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectField.NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x0005A453 File Offset: 0x00058653
		public VolumeEffectField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600B7E5 RID: 47077 RVA: 0x002DA3C4 File Offset: 0x002D85C4
		// (set) Token: 0x0600B7E6 RID: 47078 RVA: 0x0005A45C File Offset: 0x0005865C
		public unsafe string fieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600B7E7 RID: 47079 RVA: 0x002DA3EC File Offset: 0x002D85EC
		// (set) Token: 0x0600B7E8 RID: 47080 RVA: 0x0005A47B File Offset: 0x0005867B
		public unsafe string fieldType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_fieldType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600B7E9 RID: 47081 RVA: 0x002DA414 File Offset: 0x002D8614
		// (set) Token: 0x0600B7EA RID: 47082 RVA: 0x0005A49A File Offset: 0x0005869A
		public unsafe float valueSingle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueSingle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueSingle)) = value;
			}
		}

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600B7EB RID: 47083 RVA: 0x002DA43C File Offset: 0x002D863C
		// (set) Token: 0x0600B7EC RID: 47084 RVA: 0x0005A4B5 File Offset: 0x000586B5
		public unsafe Color valueColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueColor)) = value;
			}
		}

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600B7ED RID: 47085 RVA: 0x002DA464 File Offset: 0x002D8664
		// (set) Token: 0x0600B7EE RID: 47086 RVA: 0x0005A4D0 File Offset: 0x000586D0
		public unsafe bool valueBoolean
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueBoolean);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueBoolean)) = value;
			}
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600B7EF RID: 47087 RVA: 0x002DA48C File Offset: 0x002D868C
		// (set) Token: 0x0600B7F0 RID: 47088 RVA: 0x0005A4EB File Offset: 0x000586EB
		public unsafe Vector2 valueVector2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector2)) = value;
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600B7F1 RID: 47089 RVA: 0x002DA4B4 File Offset: 0x002D86B4
		// (set) Token: 0x0600B7F2 RID: 47090 RVA: 0x0005A506 File Offset: 0x00058706
		public unsafe Vector3 valueVector3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector3)) = value;
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x002DA4DC File Offset: 0x002D86DC
		// (set) Token: 0x0600B7F4 RID: 47092 RVA: 0x0005A521 File Offset: 0x00058721
		public unsafe Vector4 valueVector4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectField.NativeFieldInfoPtr_valueVector4)) = value;
			}
		}

		// Token: 0x04007BE5 RID: 31717
		private static readonly IntPtr NativeFieldInfoPtr_fieldName;

		// Token: 0x04007BE6 RID: 31718
		private static readonly IntPtr NativeFieldInfoPtr_fieldType;

		// Token: 0x04007BE7 RID: 31719
		private static readonly IntPtr NativeFieldInfoPtr_valueSingle;

		// Token: 0x04007BE8 RID: 31720
		private static readonly IntPtr NativeFieldInfoPtr_valueColor;

		// Token: 0x04007BE9 RID: 31721
		private static readonly IntPtr NativeFieldInfoPtr_valueBoolean;

		// Token: 0x04007BEA RID: 31722
		private static readonly IntPtr NativeFieldInfoPtr_valueVector2;

		// Token: 0x04007BEB RID: 31723
		private static readonly IntPtr NativeFieldInfoPtr_valueVector3;

		// Token: 0x04007BEC RID: 31724
		private static readonly IntPtr NativeFieldInfoPtr_valueVector4;

		// Token: 0x04007BED RID: 31725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04007BEE RID: 31726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_Component_0;

		// Token: 0x04007BEF RID: 31727
		private static readonly IntPtr NativeMethodInfoPtr_IsValidType_Public_Static_Boolean_String_0;

		// Token: 0x04007BF0 RID: 31728
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Public_Void_Object_0;
	}
}
