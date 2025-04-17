using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079A RID: 1946
	[Serializable]
	public class VolumeEffectFieldFlags : Object
	{
		// Token: 0x0600B81E RID: 47134 RVA: 0x002DB080 File Offset: 0x002D9280
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectFieldFlags()
		{
			Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectFieldFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr);
			VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "fieldName");
			VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "fieldType");
			VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, "blendFlag");
			VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, 100685926);
			VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr, 100685927);
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x002DB114 File Offset: 0x002D9314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313249, RefRangeEnd = 313251, XrefRangeStart = 313245, XrefRangeEnd = 313249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFieldFlags(FieldInfo pi) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x002DB160 File Offset: 0x002D9360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313251, XrefRangeEnd = 313254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFieldFlags(VolumeEffectField field) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFieldFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFieldFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x0005A5F2 File Offset: 0x000587F2
		public VolumeEffectFieldFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390A RID: 14602
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x002DB1AC File Offset: 0x002D93AC
		// (set) Token: 0x0600B823 RID: 47139 RVA: 0x0005A5FB File Offset: 0x000587FB
		public unsafe string fieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700390B RID: 14603
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x002DB1D4 File Offset: 0x002D93D4
		// (set) Token: 0x0600B825 RID: 47141 RVA: 0x0005A61A File Offset: 0x0005881A
		public unsafe string fieldType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_fieldType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700390C RID: 14604
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x002DB1FC File Offset: 0x002D93FC
		// (set) Token: 0x0600B827 RID: 47143 RVA: 0x0005A639 File Offset: 0x00058839
		public unsafe bool blendFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFieldFlags.NativeFieldInfoPtr_blendFlag)) = value;
			}
		}

		// Token: 0x04007C0F RID: 31759
		private static readonly IntPtr NativeFieldInfoPtr_fieldName;

		// Token: 0x04007C10 RID: 31760
		private static readonly IntPtr NativeFieldInfoPtr_fieldType;

		// Token: 0x04007C11 RID: 31761
		private static readonly IntPtr NativeFieldInfoPtr_blendFlag;

		// Token: 0x04007C12 RID: 31762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_0;

		// Token: 0x04007C13 RID: 31763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectField_0;
	}
}
