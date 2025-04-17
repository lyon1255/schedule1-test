using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000797 RID: 1943
	[Serializable]
	public class VolumeEffectComponent : Il2CppSystem.Object
	{
		// Token: 0x0600B7F5 RID: 47093 RVA: 0x002DA504 File Offset: 0x002D8704
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectComponent()
		{
			Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr);
			VolumeEffectComponent.NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "componentName");
			VolumeEffectComponent.NativeFieldInfoPtr_fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "fields");
			VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685888);
			VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685889);
			VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685890);
			VolumeEffectComponent.NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685891);
			VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685892);
			VolumeEffectComponent.NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685893);
			VolumeEffectComponent.NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685894);
			VolumeEffectComponent.NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685895);
			VolumeEffectComponent.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, 100685896);
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x002DA610 File Offset: 0x002D8810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312648, RefRangeEnd = 312650, XrefRangeStart = 312639, XrefRangeEnd = 312648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x002DA65C File Offset: 0x002D885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312650, XrefRangeEnd = 312661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField AddField(FieldInfo pi, Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x002DA6C0 File Offset: 0x002D88C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312661, XrefRangeEnd = 312675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField AddField(FieldInfo pi, Component c, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x002DA730 File Offset: 0x002D8930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312675, XrefRangeEnd = 312679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEffectField(VolumeEffectField field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x002DA774 File Offset: 0x002D8974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 312704, RefRangeEnd = 312705, XrefRangeStart = 312679, XrefRangeEnd = 312704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x002DA7D4 File Offset: 0x002D89D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312705, XrefRangeEnd = 312743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x002DA828 File Offset: 0x002D8A28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 312751, RefRangeEnd = 312756, XrefRangeStart = 312743, XrefRangeEnd = 312751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectField FindEffectField(string fieldName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr3) : null;
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x002DA878 File Offset: 0x002D8A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312756, XrefRangeEnd = 312787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<FieldInfo> ListAcceptableFields(Component c)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr3) : null;
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x002DA8BC File Offset: 0x002D8ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312787, XrefRangeEnd = 312808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetFieldNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x0005A53C File Offset: 0x0005873C
		public VolumeEffectComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003905 RID: 14597
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x002DA8FC File Offset: 0x002D8AFC
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x0005A545 File Offset: 0x00058745
		public unsafe string componentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_componentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003906 RID: 14598
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x002DA924 File Offset: 0x002D8B24
		// (set) Token: 0x0600B803 RID: 47107 RVA: 0x0005A564 File Offset: 0x00058764
		public unsafe List<VolumeEffectField> fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.NativeFieldInfoPtr_fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BF1 RID: 31729
		private static readonly IntPtr NativeFieldInfoPtr_componentName;

		// Token: 0x04007BF2 RID: 31730
		private static readonly IntPtr NativeFieldInfoPtr_fields;

		// Token: 0x04007BF3 RID: 31731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04007BF4 RID: 31732
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_0;

		// Token: 0x04007BF5 RID: 31733
		private static readonly IntPtr NativeMethodInfoPtr_AddField_Public_VolumeEffectField_FieldInfo_Component_Int32_0;

		// Token: 0x04007BF6 RID: 31734
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEffectField_Public_Void_VolumeEffectField_0;

		// Token: 0x04007BF7 RID: 31735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007BF8 RID: 31736
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponent_Public_Void_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007BF9 RID: 31737
		private static readonly IntPtr NativeMethodInfoPtr_FindEffectField_Public_VolumeEffectField_String_0;

		// Token: 0x04007BFA RID: 31738
		private static readonly IntPtr NativeMethodInfoPtr_ListAcceptableFields_Public_Static_Il2CppReferenceArray_1_FieldInfo_Component_0;

		// Token: 0x04007BFB RID: 31739
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C0B RID: 3083
		[ObfuscatedName("AmplifyColor.VolumeEffectComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E03E RID: 57406 RVA: 0x0034CC80 File Offset: 0x0034AE80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr);
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9");
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9__9_0");
				VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, "<>9__10_0");
				VolumeEffectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685898);
				VolumeEffectComponent.__c.NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685899);
				VolumeEffectComponent.__c.NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr, 100685900);
			}

			// Token: 0x0600E03F RID: 57407 RVA: 0x0034CD24 File Offset: 0x0034AF24
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E040 RID: 57408 RVA: 0x0034CD60 File Offset: 0x0034AF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312637, XrefRangeEnd = 312639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ListAcceptableFields_b__9_0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E041 RID: 57409 RVA: 0x0034CDB0 File Offset: 0x0034AFB0
			[CallerCount(0)]
			public unsafe string _GetFieldNames_b__10_0(VolumeEffectField r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c.NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E042 RID: 57410 RVA: 0x0006D504 File Offset: 0x0006B704
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0600E043 RID: 57411 RVA: 0x0034CDF8 File Offset: 0x0034AFF8
			// (set) Token: 0x0600E044 RID: 57412 RVA: 0x0006D50D File Offset: 0x0006B70D
			public unsafe static VolumeEffectComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457D RID: 17789
			// (get) Token: 0x0600E045 RID: 57413 RVA: 0x0034CE20 File Offset: 0x0034B020
			// (set) Token: 0x0600E046 RID: 57414 RVA: 0x0006D51F File Offset: 0x0006B71F
			public unsafe static Func<FieldInfo, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700457E RID: 17790
			// (get) Token: 0x0600E047 RID: 57415 RVA: 0x0034CE48 File Offset: 0x0034B048
			// (set) Token: 0x0600E048 RID: 57416 RVA: 0x0006D531 File Offset: 0x0006B731
			public unsafe static Func<VolumeEffectField, string> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectField, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponent.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009639 RID: 38457
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400963A RID: 38458
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400963B RID: 38459
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400963C RID: 38460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400963D RID: 38461
			private static readonly IntPtr NativeMethodInfoPtr__ListAcceptableFields_b__9_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x0400963E RID: 38462
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__10_0_Internal_String_VolumeEffectField_0;
		}

		// Token: 0x02000C0C RID: 3084
		[ObfuscatedName("AmplifyColor.VolumeEffectComponent+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E049 RID: 57417 RVA: 0x0034CE70 File Offset: 0x0034B070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponent>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr);
				VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, "fieldFlags");
				VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, 100685901);
				VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr, 100685902);
			}

			// Token: 0x0600E04A RID: 57418 RVA: 0x0034CED8 File Offset: 0x0034B0D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponent.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E04B RID: 57419 RVA: 0x0034CF14 File Offset: 0x0034B114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponent_b__0(VolumeEffectField s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponent.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E04C RID: 57420 RVA: 0x0006D543 File Offset: 0x0006B743
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700457F RID: 17791
			// (get) Token: 0x0600E04D RID: 57421 RVA: 0x0034CF64 File Offset: 0x0034B164
			// (set) Token: 0x0600E04E RID: 57422 RVA: 0x0006D54C File Offset: 0x0006B74C
			public unsafe VolumeEffectFieldFlags fieldFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectFieldFlags>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponent.__c__DisplayClass7_0.NativeFieldInfoPtr_fieldFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400963F RID: 38463
			private static readonly IntPtr NativeFieldInfoPtr_fieldFlags;

			// Token: 0x04009640 RID: 38464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009641 RID: 38465
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponent_b__0_Internal_Boolean_VolumeEffectField_0;
		}
	}
}
