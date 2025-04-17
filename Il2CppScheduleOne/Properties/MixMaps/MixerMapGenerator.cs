using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001F6 RID: 502
	public class MixerMapGenerator : MonoBehaviour
	{
		// Token: 0x0600289A RID: 10394 RVA: 0x000F0C78 File Offset: 0x000EEE78
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMapGenerator()
		{
			Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMapGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr);
			MixerMapGenerator.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapRadius");
			MixerMapGenerator.NativeFieldInfoPtr_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "MapName");
			MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "BasePlateMesh");
			MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "EffectPrefab");
			MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667874);
			MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667875);
			MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667876);
			MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, 100667877);
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x000F0D48 File Offset: 0x000EEF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118593, XrefRangeEnd = 118599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x000F0D7C File Offset: 0x000EEF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118599, XrefRangeEnd = 118637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEffectPrefabs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000F0DB0 File Offset: 0x000EEFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118637, XrefRangeEnd = 118655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Effect GetEffect(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr3) : null;
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x000F0E00 File Offset: 0x000EF000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118655, XrefRangeEnd = 118660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0001610F File Offset: 0x0001430F
		public MixerMapGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000F0E3C File Offset: 0x000EF03C
		// (set) Token: 0x060028A1 RID: 10401 RVA: 0x00016118 File Offset: 0x00014318
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x000F0E64 File Offset: 0x000EF064
		// (set) Token: 0x060028A3 RID: 10403 RVA: 0x00016133 File Offset: 0x00014333
		public unsafe string MapName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x000F0E8C File Offset: 0x000EF08C
		// (set) Token: 0x060028A5 RID: 10405 RVA: 0x00016152 File Offset: 0x00014352
		public unsafe Transform BasePlateMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_BasePlateMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x000F0EBC File Offset: 0x000EF0BC
		// (set) Token: 0x060028A7 RID: 10407 RVA: 0x00016171 File Offset: 0x00014371
		public unsafe Effect EffectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Effect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.NativeFieldInfoPtr_EffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AF0 RID: 6896
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x04001AF1 RID: 6897
		private static readonly IntPtr NativeFieldInfoPtr_MapName;

		// Token: 0x04001AF2 RID: 6898
		private static readonly IntPtr NativeFieldInfoPtr_BasePlateMesh;

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_EffectPrefab;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_CreateEffectPrefabs_Public_Void_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_Effect_Property_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D9 RID: 2265
		[ObfuscatedName("ScheduleOne.Properties.MixMaps.MixerMapGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C449 RID: 50249 RVA: 0x002FD160 File Offset: 0x002FB360
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MixerMapGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, "property");
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667878);
				MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100667879);
			}

			// Token: 0x0600C44A RID: 50250 RVA: 0x002FD1C8 File Offset: 0x002FB3C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMapGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C44B RID: 50251 RVA: 0x002FD204 File Offset: 0x002FB404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118574, XrefRangeEnd = 118593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEffect_b__0(Effect effect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(effect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMapGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C44C RID: 50252 RVA: 0x0005F860 File Offset: 0x0005DA60
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D42 RID: 15682
			// (get) Token: 0x0600C44D RID: 50253 RVA: 0x002FD254 File Offset: 0x002FB454
			// (set) Token: 0x0600C44E RID: 50254 RVA: 0x0005F869 File Offset: 0x0005DA69
			public unsafe Property property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMapGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008503 RID: 34051
			private static readonly IntPtr NativeFieldInfoPtr_property;

			// Token: 0x04008504 RID: 34052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008505 RID: 34053
			private static readonly IntPtr NativeMethodInfoPtr__GetEffect_b__0_Internal_Boolean_Effect_0;
		}
	}
}
