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
	// Token: 0x0200079B RID: 1947
	[Serializable]
	public class VolumeEffectComponentFlags : Il2CppSystem.Object
	{
		// Token: 0x0600B828 RID: 47144 RVA: 0x002DB224 File Offset: 0x002D9424
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectComponentFlags()
		{
			Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectComponentFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr);
			VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "componentName");
			VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "componentFields");
			VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "blendFlag");
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685928);
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685929);
			VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685930);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685931);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685932);
			VolumeEffectComponentFlags.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, 100685933);
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x002DB308 File Offset: 0x002D9508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313335, RefRangeEnd = 313337, XrefRangeStart = 313326, XrefRangeEnd = 313335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x002DB354 File Offset: 0x002D9554
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313362, RefRangeEnd = 313363, XrefRangeStart = 313337, XrefRangeEnd = 313362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(VolumeEffectComponent comp) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x002DB3A0 File Offset: 0x002D95A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313378, RefRangeEnd = 313379, XrefRangeStart = 313363, XrefRangeEnd = 313378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags(Component c) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr__ctor_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82C RID: 47148 RVA: 0x002DB3EC File Offset: 0x002D95EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313417, RefRangeEnd = 313418, XrefRangeStart = 313379, XrefRangeEnd = 313417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponentFlags(VolumeEffectComponent comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x002DB430 File Offset: 0x002D9630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313418, XrefRangeEnd = 313443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateComponentFlags(Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x002DB474 File Offset: 0x002D9674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313443, XrefRangeEnd = 313481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetFieldNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x0005A654 File Offset: 0x00058854
		public VolumeEffectComponentFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x0600B830 RID: 47152 RVA: 0x002DB4B4 File Offset: 0x002D96B4
		// (set) Token: 0x0600B831 RID: 47153 RVA: 0x0005A65D File Offset: 0x0005885D
		public unsafe string componentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x0600B832 RID: 47154 RVA: 0x002DB4DC File Offset: 0x002D96DC
		// (set) Token: 0x0600B833 RID: 47155 RVA: 0x0005A67C File Offset: 0x0005887C
		public unsafe List<VolumeEffectFieldFlags> componentFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectFieldFlags>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_componentFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x0600B834 RID: 47156 RVA: 0x002DB50C File Offset: 0x002D970C
		// (set) Token: 0x0600B835 RID: 47157 RVA: 0x0005A69B File Offset: 0x0005889B
		public unsafe bool blendFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.NativeFieldInfoPtr_blendFlag)) = value;
			}
		}

		// Token: 0x04007C14 RID: 31764
		private static readonly IntPtr NativeFieldInfoPtr_componentName;

		// Token: 0x04007C15 RID: 31765
		private static readonly IntPtr NativeFieldInfoPtr_componentFields;

		// Token: 0x04007C16 RID: 31766
		private static readonly IntPtr NativeFieldInfoPtr_blendFlag;

		// Token: 0x04007C17 RID: 31767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04007C18 RID: 31768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C19 RID: 31769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Component_0;

		// Token: 0x04007C1A RID: 31770
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C1B RID: 31771
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComponentFlags_Public_Void_Component_0;

		// Token: 0x04007C1C RID: 31772
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C0F RID: 3087
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E062 RID: 57442 RVA: 0x0034D2DC File Offset: 0x0034B4DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr);
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9");
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9__8_0");
				VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, "<>9__8_1");
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685935);
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685936);
				VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr, 100685937);
			}

			// Token: 0x0600E063 RID: 57443 RVA: 0x0034D380 File Offset: 0x0034B580
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E064 RID: 57444 RVA: 0x0034D3BC File Offset: 0x0034B5BC
			[CallerCount(0)]
			public unsafe bool _GetFieldNames_b__8_0(VolumeEffectFieldFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E065 RID: 57445 RVA: 0x0034D40C File Offset: 0x0034B60C
			[CallerCount(0)]
			public unsafe string _GetFieldNames_b__8_1(VolumeEffectFieldFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c.NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E066 RID: 57446 RVA: 0x0006D5D7 File Offset: 0x0006B7D7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004585 RID: 17797
			// (get) Token: 0x0600E067 RID: 57447 RVA: 0x0034D454 File Offset: 0x0034B654
			// (set) Token: 0x0600E068 RID: 57448 RVA: 0x0006D5E0 File Offset: 0x0006B7E0
			public unsafe static VolumeEffectComponentFlags.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponentFlags.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004586 RID: 17798
			// (get) Token: 0x0600E069 RID: 57449 RVA: 0x0034D47C File Offset: 0x0034B67C
			// (set) Token: 0x0600E06A RID: 57450 RVA: 0x0006D5F2 File Offset: 0x0006B7F2
			public unsafe static Func<VolumeEffectFieldFlags, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectFieldFlags, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004587 RID: 17799
			// (get) Token: 0x0600E06B RID: 57451 RVA: 0x0034D4A4 File Offset: 0x0034B6A4
			// (set) Token: 0x0600E06C RID: 57452 RVA: 0x0006D604 File Offset: 0x0006B804
			public unsafe static Func<VolumeEffectFieldFlags, string> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectFieldFlags, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectComponentFlags.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400964C RID: 38476
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400964D RID: 38477
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400964E RID: 38478
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400964F RID: 38479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009650 RID: 38480
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__8_0_Internal_Boolean_VolumeEffectFieldFlags_0;

			// Token: 0x04009651 RID: 38481
			private static readonly IntPtr NativeMethodInfoPtr__GetFieldNames_b__8_1_Internal_String_VolumeEffectFieldFlags_0;
		}

		// Token: 0x02000C10 RID: 3088
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E06D RID: 57453 RVA: 0x0034D4CC File Offset: 0x0034B6CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr);
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, "field");
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, 100685938);
				VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr, 100685939);
			}

			// Token: 0x0600E06E RID: 57454 RVA: 0x0034D534 File Offset: 0x0034B734
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E06F RID: 57455 RVA: 0x0034D570 File Offset: 0x0034B770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponentFlags_b__0(VolumeEffectFieldFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E070 RID: 57456 RVA: 0x0006D616 File Offset: 0x0006B816
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0600E071 RID: 57457 RVA: 0x0034D5C0 File Offset: 0x0034B7C0
			// (set) Token: 0x0600E072 RID: 57458 RVA: 0x0006D61F File Offset: 0x0006B81F
			public unsafe VolumeEffectField field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectField>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass6_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009652 RID: 38482
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x04009653 RID: 38483
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009654 RID: 38484
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0;
		}

		// Token: 0x02000C11 RID: 3089
		[ObfuscatedName("AmplifyColor.VolumeEffectComponentFlags+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E073 RID: 57459 RVA: 0x0034D5F0 File Offset: 0x0034B7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectComponentFlags>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr);
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, "pi");
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, 100685940);
				VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr, 100685941);
			}

			// Token: 0x0600E074 RID: 57460 RVA: 0x0034D658 File Offset: 0x0034B858
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectComponentFlags.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E075 RID: 57461 RVA: 0x0034D694 File Offset: 0x0034B894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313254, XrefRangeEnd = 313326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateComponentFlags_b__0(VolumeEffectFieldFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E076 RID: 57462 RVA: 0x0006D63E File Offset: 0x0006B83E
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0600E077 RID: 57463 RVA: 0x0034D6E4 File Offset: 0x0034B8E4
			// (set) Token: 0x0600E078 RID: 57464 RVA: 0x0006D647 File Offset: 0x0006B847
			public unsafe FieldInfo pi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectComponentFlags.__c__DisplayClass7_0.NativeFieldInfoPtr_pi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009655 RID: 38485
			private static readonly IntPtr NativeFieldInfoPtr_pi;

			// Token: 0x04009656 RID: 38486
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009657 RID: 38487
			private static readonly IntPtr NativeMethodInfoPtr__UpdateComponentFlags_b__0_Internal_Boolean_VolumeEffectFieldFlags_0;
		}
	}
}
