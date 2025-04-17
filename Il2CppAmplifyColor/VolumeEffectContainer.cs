using System;
using Il2Cpp;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppAmplifyColor
{
	// Token: 0x02000799 RID: 1945
	[Serializable]
	public class VolumeEffectContainer : Object
	{
		// Token: 0x0600B814 RID: 47124 RVA: 0x002DADF0 File Offset: 0x002D8FF0
		// Note: this type is marked as 'beforefieldinit'.
		static VolumeEffectContainer()
		{
			Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AmplifyColor", "VolumeEffectContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr);
			VolumeEffectContainer.NativeFieldInfoPtr_volumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, "volumes");
			VolumeEffectContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685917);
			VolumeEffectContainer.NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685918);
			VolumeEffectContainer.NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685919);
			VolumeEffectContainer.NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685920);
			VolumeEffectContainer.NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685921);
			VolumeEffectContainer.NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, 100685922);
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x002DAEAC File Offset: 0x002D90AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313187, RefRangeEnd = 313188, XrefRangeStart = 313179, XrefRangeEnd = 313187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffectContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x002DAEE8 File Offset: 0x002D90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313188, XrefRangeEnd = 313199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddColorEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x002DAF2C File Offset: 0x002D912C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313199, XrefRangeEnd = 313206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect AddJustColorEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x002DAF7C File Offset: 0x002D917C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 313217, RefRangeEnd = 313220, XrefRangeStart = 313206, XrefRangeEnd = 313217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumeEffect FindVolumeEffect(AmplifyColorEffect colorEffect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorEffect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VolumeEffect>(intPtr3) : null;
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x002DAFCC File Offset: 0x002D91CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313220, XrefRangeEnd = 313224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveVolumeEffect(VolumeEffect volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(volume);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x002DB010 File Offset: 0x002D9210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313224, XrefRangeEnd = 313245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<AmplifyColorEffect> GetStoredEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AmplifyColorEffect>>(intPtr3) : null;
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x0005A5CA File Offset: 0x000587CA
		public VolumeEffectContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003909 RID: 14601
		// (get) Token: 0x0600B81C RID: 47132 RVA: 0x002DB050 File Offset: 0x002D9250
		// (set) Token: 0x0600B81D RID: 47133 RVA: 0x0005A5D3 File Offset: 0x000587D3
		public unsafe List<VolumeEffect> volumes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectContainer.NativeFieldInfoPtr_volumes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VolumeEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumeEffectContainer.NativeFieldInfoPtr_volumes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C08 RID: 31752
		private static readonly IntPtr NativeFieldInfoPtr_volumes;

		// Token: 0x04007C09 RID: 31753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007C0A RID: 31754
		private static readonly IntPtr NativeMethodInfoPtr_AddColorEffect_Public_Void_AmplifyColorEffect_0;

		// Token: 0x04007C0B RID: 31755
		private static readonly IntPtr NativeMethodInfoPtr_AddJustColorEffect_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C0C RID: 31756
		private static readonly IntPtr NativeMethodInfoPtr_FindVolumeEffect_Public_VolumeEffect_AmplifyColorEffect_0;

		// Token: 0x04007C0D RID: 31757
		private static readonly IntPtr NativeMethodInfoPtr_RemoveVolumeEffect_Public_Void_VolumeEffect_0;

		// Token: 0x04007C0E RID: 31758
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredEffects_Public_Il2CppReferenceArray_1_AmplifyColorEffect_0;

		// Token: 0x02000C0E RID: 3086
		[ObfuscatedName("AmplifyColor.VolumeEffectContainer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E05A RID: 57434 RVA: 0x0034D184 File Offset: 0x0034B384
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VolumeEffectContainer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr);
				VolumeEffectContainer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, "<>9");
				VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, "<>9__6_0");
				VolumeEffectContainer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, 100685924);
				VolumeEffectContainer.__c.NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr, 100685925);
			}

			// Token: 0x0600E05B RID: 57435 RVA: 0x0034D200 File Offset: 0x0034B400
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumeEffectContainer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E05C RID: 57436 RVA: 0x0034D23C File Offset: 0x0034B43C
			[CallerCount(0)]
			public unsafe AmplifyColorEffect _GetStoredEffects_b__6_0(VolumeEffect r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumeEffectContainer.__c.NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AmplifyColorEffect>(intPtr3) : null;
			}

			// Token: 0x0600E05D RID: 57437 RVA: 0x0006D5AA File Offset: 0x0006B7AA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004583 RID: 17795
			// (get) Token: 0x0600E05E RID: 57438 RVA: 0x0034D28C File Offset: 0x0034B48C
			// (set) Token: 0x0600E05F RID: 57439 RVA: 0x0006D5B3 File Offset: 0x0006B7B3
			public unsafe static VolumeEffectContainer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumeEffectContainer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004584 RID: 17796
			// (get) Token: 0x0600E060 RID: 57440 RVA: 0x0034D2B4 File Offset: 0x0034B4B4
			// (set) Token: 0x0600E061 RID: 57441 RVA: 0x0006D5C5 File Offset: 0x0006B7C5
			public unsafe static Func<VolumeEffect, AmplifyColorEffect> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VolumeEffect, AmplifyColorEffect>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VolumeEffectContainer.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009648 RID: 38472
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009649 RID: 38473
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400964A RID: 38474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400964B RID: 38475
			private static readonly IntPtr NativeMethodInfoPtr__GetStoredEffects_b__6_0_Internal_AmplifyColorEffect_VolumeEffect_0;
		}
	}
}
