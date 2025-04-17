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
	// Token: 0x02000798 RID: 1944
	[Serializable]
	public class VolumeEffect : Il2CppSystem.Object
	{
		// Token: 0x0600B804 RID: 47108 RVA: 0x002DA954 File Offset: 0x002D8B54
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffect()
		{
			Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr);
			VolumeEffect.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "gameObject");
			VolumeEffect.NativeFieldInfoPtr_components = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "components");
			VolumeEffect.NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685903);
			VolumeEffect.NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685904);
			VolumeEffect.NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685905);
			VolumeEffect.NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685906);
			VolumeEffect.NativeMethodInfoPtr_UpdateVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685907);
			VolumeEffect.NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685908);
			VolumeEffect.NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685909);
			VolumeEffect.NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685910);
			VolumeEffect.NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685911);
			VolumeEffect.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, 100685912);
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x002DAA74 File Offset: 0x002D8C74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 312829, RefRangeEnd = 312833, XrefRangeStart = 312820, XrefRangeEnd = 312829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect(AmplifyColorEffect effect) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x002DAAC0 File Offset: 0x002D8CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312917, RefRangeEnd = 312919, XrefRangeStart = 312833, XrefRangeEnd = 312917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VolumeEffect BlendValuesToVolumeEffect(VolumeEffectFlags flags, VolumeEffect volume1, VolumeEffect volume2, float blend)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volume1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(volume2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x002DAB38 File Offset: 0x002D8D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312930, RefRangeEnd = 312932, XrefRangeStart = 312919, XrefRangeEnd = 312930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent AddComponent(Component c, VolumeEffectComponentFlags compFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr3) : null;
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x002DAB9C File Offset: 0x002D8D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312932, XrefRangeEnd = 312936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEffectComponent(VolumeEffectComponent comp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x002DABE0 File Offset: 0x002D8DE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 312959, RefRangeEnd = 312961, XrefRangeStart = 312936, XrefRangeEnd = 312959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_UpdateVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x002DAC14 File Offset: 0x002D8E14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313037, RefRangeEnd = 313038, XrefRangeStart = 312961, XrefRangeEnd = 313037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValues(AmplifyColorEffect targetColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x002DAC58 File Offset: 0x002D8E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313107, RefRangeEnd = 313108, XrefRangeStart = 313038, XrefRangeEnd = 313107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlendValues(AmplifyColorEffect targetColor, VolumeEffect other, float blendAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetColor);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blendAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x002DACBC File Offset: 0x002D8EBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 313116, RefRangeEnd = 313122, XrefRangeStart = 313108, XrefRangeEnd = 313116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectComponent FindEffectComponent(string compName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(compName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffectComponent>(intPtr3) : null;
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x002DAD0C File Offset: 0x002D8F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313122, XrefRangeEnd = 313158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Component> ListAcceptableComponents(AmplifyColorEffect go)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr3) : null;
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x002DAD50 File Offset: 0x002D8F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313158, XrefRangeEnd = 313179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetComponentNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x0005A583 File Offset: 0x00058783
		public VolumeEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003907 RID: 14599
		// (get) Token: 0x0600B810 RID: 47120 RVA: 0x002DAD90 File Offset: 0x002D8F90
		// (set) Token: 0x0600B811 RID: 47121 RVA: 0x0005A58C File Offset: 0x0005878C
		public unsafe AmplifyColorEffect gameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_gameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003908 RID: 14600
		// (get) Token: 0x0600B812 RID: 47122 RVA: 0x002DADC0 File Offset: 0x002D8FC0
		// (set) Token: 0x0600B813 RID: 47123 RVA: 0x0005A5AB File Offset: 0x000587AB
		public unsafe List<VolumeEffectComponent> components
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_components);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffectComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffect.NativeFieldInfoPtr_components), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BFC RID: 31740
		private static readonly IntPtr NativeFieldInfoPtr_gameObject;

		// Token: 0x04007BFD RID: 31741
		private static readonly IntPtr NativeFieldInfoPtr_components;

		// Token: 0x04007BFE RID: 31742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007BFF RID: 31743
		private static readonly IntPtr NativeMethodInfoPtr_BlendValuesToVolumeEffect_Public_Static_VolumeEffect_VolumeEffectFlags_VolumeEffect_VolumeEffect_Single_0;

		// Token: 0x04007C00 RID: 31744
		private static readonly IntPtr NativeMethodInfoPtr_AddComponent_Public_VolumeEffectComponent_Component_VolumeEffectComponentFlags_0;

		// Token: 0x04007C01 RID: 31745
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEffectComponent_Public_Void_VolumeEffectComponent_0;

		// Token: 0x04007C02 RID: 31746
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVolume_Public_Void_0;

		// Token: 0x04007C03 RID: 31747
		private static readonly IntPtr NativeMethodInfoPtr_SetValues_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007C04 RID: 31748
		private static readonly IntPtr NativeMethodInfoPtr_BlendValues_Public_Void_AmplifyColorEffect_VolumeEffect_Single_0;

		// Token: 0x04007C05 RID: 31749
		private static readonly IntPtr NativeMethodInfoPtr_FindEffectComponent_Public_VolumeEffectComponent_String_0;

		// Token: 0x04007C06 RID: 31750
		private static readonly IntPtr NativeMethodInfoPtr_ListAcceptableComponents_Public_Static_Il2CppReferenceArray_1_Component_AmplifyColorEffect_0;

		// Token: 0x04007C07 RID: 31751
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentNames_Public_Il2CppStringArray_0;

		// Token: 0x02000C0D RID: 3085
		[ObfuscatedName("AmplifyColor.VolumeEffect+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E04F RID: 57423 RVA: 0x0034CF94 File Offset: 0x0034B194
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffect>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr);
				VolumeEffect.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9");
				VolumeEffect.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9__10_0");
				VolumeEffect.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, "<>9__11_0");
				VolumeEffect.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685914);
				VolumeEffect.__c.NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685915);
				VolumeEffect.__c.NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr, 100685916);
			}

			// Token: 0x0600E050 RID: 57424 RVA: 0x0034D038 File Offset: 0x0034B238
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffect.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E051 RID: 57425 RVA: 0x0034D074 File Offset: 0x0034B274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 312808, XrefRangeEnd = 312820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ListAcceptableComponents_b__10_0(Component comp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E052 RID: 57426 RVA: 0x0034D0C4 File Offset: 0x0034B2C4
			[CallerCount(0)]
			public unsafe string _GetComponentNames_b__11_0(VolumeEffectComponent r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffect.__c.NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E053 RID: 57427 RVA: 0x0006D56B File Offset: 0x0006B76B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004580 RID: 17792
			// (get) Token: 0x0600E054 RID: 57428 RVA: 0x0034D10C File Offset: 0x0034B30C
			// (set) Token: 0x0600E055 RID: 57429 RVA: 0x0006D574 File Offset: 0x0006B774
			public unsafe static VolumeEffect.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffect.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004581 RID: 17793
			// (get) Token: 0x0600E056 RID: 57430 RVA: 0x0034D134 File Offset: 0x0034B334
			// (set) Token: 0x0600E057 RID: 57431 RVA: 0x0006D586 File Offset: 0x0006B786
			public unsafe static Func<Component, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Component, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004582 RID: 17794
			// (get) Token: 0x0600E058 RID: 57432 RVA: 0x0034D15C File Offset: 0x0034B35C
			// (set) Token: 0x0600E059 RID: 57433 RVA: 0x0006D598 File Offset: 0x0006B798
			public unsafe static Func<VolumeEffectComponent, string> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffect.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffectComponent, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffect.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009642 RID: 38466
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009643 RID: 38467
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009644 RID: 38468
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04009645 RID: 38469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009646 RID: 38470
			private static readonly IntPtr NativeMethodInfoPtr__ListAcceptableComponents_b__10_0_Internal_Boolean_Component_0;

			// Token: 0x04009647 RID: 38471
			private static readonly IntPtr NativeMethodInfoPtr__GetComponentNames_b__11_0_Internal_String_VolumeEffectComponent_0;
		}
	}
}
