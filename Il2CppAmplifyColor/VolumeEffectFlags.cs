using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAmplifyColor
{
	// Token: 0x0200079C RID: 1948
	[Serializable]
	public class VolumeEffectFlags : Il2CppSystem.Object
	{
		// Token: 0x0600B836 RID: 47158 RVA: 0x002DB534 File Offset: 0x002D9734
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectFlags()
		{
			Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectFlags");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr);
			VolumeEffectFlags.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "components");
			VolumeEffectFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685942);
			VolumeEffectFlags.NativeMethodInfoPtr_AddComponent_Public_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685943);
			VolumeEffectFlags.NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685944);
			VolumeEffectFlags.NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685945);
			VolumeEffectFlags.NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685946);
			VolumeEffectFlags.NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685947);
			VolumeEffectFlags.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, 100685948);
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x002DB604 File Offset: 0x002D9804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313494, RefRangeEnd = 313495, XrefRangeStart = 313486, XrefRangeEnd = 313494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectFlags() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x002DB640 File Offset: 0x002D9840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313495, XrefRangeEnd = 313516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddComponent(Component c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_AddComponent_Public_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B839 RID: 47161 RVA: 0x002DB684 File Offset: 0x002D9884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313553, RefRangeEnd = 313554, XrefRangeStart = 313516, XrefRangeEnd = 313553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFlags(VolumeEffect effectVol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effectVol);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B83A RID: 47162 RVA: 0x002DB6C8 File Offset: 0x002D98C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313554, XrefRangeEnd = 313570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateCamFlags(Il2CppReferenceArray<AmplifyColorEffect> effects, Il2CppReferenceArray<AmplifyColorVolumeBase> volumes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volumes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B83B RID: 47163 RVA: 0x002DB710 File Offset: 0x002D9910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313594, RefRangeEnd = 313595, XrefRangeStart = 313570, XrefRangeEnd = 313594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect GenerateEffectData(AmplifyColorEffect go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B83C RID: 47164 RVA: 0x002DB760 File Offset: 0x002D9960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313595, XrefRangeEnd = 313603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponentFlags FindComponentFlags(string compName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponentFlags>(intPtr3) : null;
		}

		// Token: 0x0600B83D RID: 47165 RVA: 0x002DB7B0 File Offset: 0x002D99B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313603, XrefRangeEnd = 313641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetComponentNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B83E RID: 47166 RVA: 0x0005A6B6 File Offset: 0x000588B6
		public VolumeEffectFlags(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x0600B83F RID: 47167 RVA: 0x002DB7F0 File Offset: 0x002D99F0
		// (set) Token: 0x0600B840 RID: 47168 RVA: 0x0005A6BF File Offset: 0x000588BF
		public unsafe List<VolumeEffectComponentFlags> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectComponentFlags>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C1D RID: 31773
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04007C1E RID: 31774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007C1F RID: 31775
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_Void_Component_0;

		// Token: 0x04007C20 RID: 31776
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFlags_Public_Void_VolumeEffect_0;

		// Token: 0x04007C21 RID: 31777
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamFlags_Public_Static_Void_Il2CppReferenceArray_1_AmplifyColorEffect_Il2CppReferenceArray_1_AmplifyColorVolumeBase_0;

		// Token: 0x04007C22 RID: 31778
		private static readonly IntPtr NativeMethodInfoPtr_GenerateEffectData_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C23 RID: 31779
		private static readonly IntPtr NativeMethodInfoPtr_FindComponentFlags_Public_VolumeEffectComponentFlags_String_0;

		// Token: 0x04007C24 RID: 31780
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C12 RID: 3090
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E079 RID: 57465 RVA: 0x0034D714 File Offset: 0x0034B914
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr);
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9");
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9__7_0");
				VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, "<>9__7_1");
				VolumeEffectFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685950);
				VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685951);
				VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr, 100685952);
			}

			// Token: 0x0600E07A RID: 57466 RVA: 0x0034D7B8 File Offset: 0x0034B9B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E07B RID: 57467 RVA: 0x0034D7F4 File Offset: 0x0034B9F4
			[CallerCount(0)]
			public unsafe bool _GetComponentNames_b__7_0(VolumeEffectComponentFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E07C RID: 57468 RVA: 0x0034D844 File Offset: 0x0034BA44
			[CallerCount(0)]
			public unsafe string _GetComponentNames_b__7_1(VolumeEffectComponentFlags r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c.NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E07D RID: 57469 RVA: 0x0006D666 File Offset: 0x0006B866
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458A RID: 17802
			// (get) Token: 0x0600E07E RID: 57470 RVA: 0x0034D88C File Offset: 0x0034BA8C
			// (set) Token: 0x0600E07F RID: 57471 RVA: 0x0006D66F File Offset: 0x0006B86F
			public unsafe static VolumeEffectFlags.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectFlags.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458B RID: 17803
			// (get) Token: 0x0600E080 RID: 57472 RVA: 0x0034D8B4 File Offset: 0x0034BAB4
			// (set) Token: 0x0600E081 RID: 57473 RVA: 0x0006D681 File Offset: 0x0006B881
			public unsafe static Func<VolumeEffectComponentFlags, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponentFlags, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458C RID: 17804
			// (get) Token: 0x0600E082 RID: 57474 RVA: 0x0034D8DC File Offset: 0x0034BADC
			// (set) Token: 0x0600E083 RID: 57475 RVA: 0x0006D693 File Offset: 0x0006B893
			public unsafe static Func<VolumeEffectComponentFlags, string> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponentFlags, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectFlags.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009658 RID: 38488
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009659 RID: 38489
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x0400965A RID: 38490
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x0400965B RID: 38491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400965C RID: 38492
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__7_0_Internal_Boolean_VolumeEffectComponentFlags_0;

			// Token: 0x0400965D RID: 38493
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__7_1_Internal_String_VolumeEffectComponentFlags_0;
		}

		// Token: 0x02000C13 RID: 3091
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E084 RID: 57476 RVA: 0x0034D904 File Offset: 0x0034BB04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr);
				VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, "c");
				VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, 100685953);
				VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr, 100685954);
			}

			// Token: 0x0600E085 RID: 57477 RVA: 0x0034D96C File Offset: 0x0034BB6C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E086 RID: 57478 RVA: 0x0034D9A8 File Offset: 0x0034BBA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313481, XrefRangeEnd = 313486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddComponent_b__0(VolumeEffectComponentFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass2_0.NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E087 RID: 57479 RVA: 0x0006D6A5 File Offset: 0x0006B8A5
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458D RID: 17805
			// (get) Token: 0x0600E088 RID: 57480 RVA: 0x0034D9F8 File Offset: 0x0034BBF8
			// (set) Token: 0x0600E089 RID: 57481 RVA: 0x0006D6AE File Offset: 0x0006B8AE
			public unsafe Component c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass2_0.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400965E RID: 38494
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x0400965F RID: 38495
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009660 RID: 38496
			private static readonly IntPtr NativeMethodInfoPtr__AddComponent_b__0_Internal_Boolean_VolumeEffectComponentFlags_0;
		}

		// Token: 0x02000C14 RID: 3092
		[ObfuscatedName("AmplifyColor.VolumeEffectFlags+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E08A RID: 57482 RVA: 0x0034DA28 File Offset: 0x0034BC28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectFlags>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr);
				VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, "comp");
				VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, 100685955);
				VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr, 100685956);
			}

			// Token: 0x0600E08B RID: 57483 RVA: 0x0034DA90 File Offset: 0x0034BC90
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectFlags.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E08C RID: 57484 RVA: 0x0034DACC File Offset: 0x0034BCCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateFlags_b__0(VolumeEffectComponentFlags s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectFlags.__c__DisplayClass3_0.NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E08D RID: 57485 RVA: 0x0006D6CD File Offset: 0x0006B8CD
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700458E RID: 17806
			// (get) Token: 0x0600E08E RID: 57486 RVA: 0x0034DB1C File Offset: 0x0034BD1C
			// (set) Token: 0x0600E08F RID: 57487 RVA: 0x0006D6D6 File Offset: 0x0006B8D6
			public unsafe VolumeEffectComponent comp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectFlags.__c__DisplayClass3_0.NativeFieldInfoPtr_comp), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009661 RID: 38497
			private static readonly IntPtr NativeFieldInfoPtr_comp;

			// Token: 0x04009662 RID: 38498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009663 RID: 38499
			private static readonly IntPtr NativeMethodInfoPtr__UpdateFlags_b__0_Internal_Boolean_VolumeEffectComponentFlags_0;
		}
	}
}
