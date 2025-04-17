using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D8 RID: 1240
	public class SFXManager : Singleton<SFXManager>
	{
		// Token: 0x06006C65 RID: 27749 RVA: 0x001E1438 File Offset: 0x001DF638
		// Note: this type is marked as 'beforefieldinit'.
		static SFXManager()
		{
			Il2CppClassPointerStore<SFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "SFXManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager>.NativeClassPtr);
			SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "SQR_MAX_PLAYER_DISTANCE");
			SFXManager.NativeFieldInfoPtr_ImpactTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactTypes");
			SFXManager.NativeFieldInfoPtr_soundPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundPool");
			SFXManager.NativeFieldInfoPtr_soundsInUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "soundsInUse");
			SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676995);
			SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676996);
			SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676997);
			SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, 100676998);
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x001E151C File Offset: 0x001DF71C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216909, RefRangeEnd = 216912, XrefRangeStart = 216841, XrefRangeEnd = 216909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref material;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref momentum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x001E1578 File Offset: 0x001DF778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216912, XrefRangeEnd = 216925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x001E15AC File Offset: 0x001DF7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216925, XrefRangeEnd = 216935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x001E15EC File Offset: 0x001DF7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216935, XrefRangeEnd = 216957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SFXManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x00033506 File Offset: 0x00031706
		public SFXManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06006C6B RID: 27755 RVA: 0x001E1628 File Offset: 0x001DF828
		// (set) Token: 0x06006C6C RID: 27756 RVA: 0x0003350F File Offset: 0x0003170F
		public unsafe static float MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06006C6D RID: 27757 RVA: 0x001E1644 File Offset: 0x001DF844
		// (set) Token: 0x06006C6E RID: 27758 RVA: 0x0003351D File Offset: 0x0003171D
		public unsafe static float SQR_MAX_PLAYER_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SFXManager.NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x001E1660 File Offset: 0x001DF860
		// (set) Token: 0x06006C70 RID: 27760 RVA: 0x0003352B File Offset: 0x0003172B
		public unsafe List<SFXManager.ImpactType> ImpactTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SFXManager.ImpactType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_ImpactTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06006C71 RID: 27761 RVA: 0x001E1690 File Offset: 0x001DF890
		// (set) Token: 0x06006C72 RID: 27762 RVA: 0x0003354A File Offset: 0x0003174A
		public unsafe List<AudioSourceController> soundPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06006C73 RID: 27763 RVA: 0x001E16C0 File Offset: 0x001DF8C0
		// (set) Token: 0x06006C74 RID: 27764 RVA: 0x00033569 File Offset: 0x00031769
		public unsafe List<AudioSourceController> soundsInUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.NativeFieldInfoPtr_soundsInUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A1B RID: 18971
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PLAYER_DISTANCE;

		// Token: 0x04004A1C RID: 18972
		private static readonly IntPtr NativeFieldInfoPtr_SQR_MAX_PLAYER_DISTANCE;

		// Token: 0x04004A1D RID: 18973
		private static readonly IntPtr NativeFieldInfoPtr_ImpactTypes;

		// Token: 0x04004A1E RID: 18974
		private static readonly IntPtr NativeFieldInfoPtr_soundPool;

		// Token: 0x04004A1F RID: 18975
		private static readonly IntPtr NativeFieldInfoPtr_soundsInUse;

		// Token: 0x04004A20 RID: 18976
		private static readonly IntPtr NativeMethodInfoPtr_PlayImpactSound_Public_Void_EMaterial_Vector3_Single_0;

		// Token: 0x04004A21 RID: 18977
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004A22 RID: 18978
		private static readonly IntPtr NativeMethodInfoPtr_GetSource_Private_AudioSourceController_0;

		// Token: 0x04004A23 RID: 18979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A61 RID: 2657
		[Serializable]
		public class ImpactType : Il2CppSystem.Object
		{
			// Token: 0x0600D0B2 RID: 53426 RVA: 0x0032076C File Offset: 0x0031E96C
			// Note: this type is marked as 'beforefieldinit'.
			static ImpactType()
			{
				Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "ImpactType");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr);
				SFXManager.ImpactType.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Material");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxVolume");
				SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MinPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "MaxPitch");
				SFXManager.ImpactType.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, "Clips");
				SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr, 100676999);
			}

			// Token: 0x0600D0B3 RID: 53427 RVA: 0x00320824 File Offset: 0x0031EA24
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ImpactType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.ImpactType>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.ImpactType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0B4 RID: 53428 RVA: 0x000659B8 File Offset: 0x00063BB8
			public ImpactType(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D1 RID: 16593
			// (get) Token: 0x0600D0B5 RID: 53429 RVA: 0x00320860 File Offset: 0x0031EA60
			// (set) Token: 0x0600D0B6 RID: 53430 RVA: 0x000659C1 File Offset: 0x00063BC1
			public unsafe ImpactSoundEntity.EMaterial Material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Material)) = value;
				}
			}

			// Token: 0x170040D2 RID: 16594
			// (get) Token: 0x0600D0B7 RID: 53431 RVA: 0x00320888 File Offset: 0x0031EA88
			// (set) Token: 0x0600D0B8 RID: 53432 RVA: 0x000659DC File Offset: 0x00063BDC
			public unsafe float MinVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinVolume)) = value;
				}
			}

			// Token: 0x170040D3 RID: 16595
			// (get) Token: 0x0600D0B9 RID: 53433 RVA: 0x003208B0 File Offset: 0x0031EAB0
			// (set) Token: 0x0600D0BA RID: 53434 RVA: 0x000659F7 File Offset: 0x00063BF7
			public unsafe float MaxVolume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxVolume)) = value;
				}
			}

			// Token: 0x170040D4 RID: 16596
			// (get) Token: 0x0600D0BB RID: 53435 RVA: 0x003208D8 File Offset: 0x0031EAD8
			// (set) Token: 0x0600D0BC RID: 53436 RVA: 0x00065A12 File Offset: 0x00063C12
			public unsafe float MinPitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MinPitch)) = value;
				}
			}

			// Token: 0x170040D5 RID: 16597
			// (get) Token: 0x0600D0BD RID: 53437 RVA: 0x00320900 File Offset: 0x0031EB00
			// (set) Token: 0x0600D0BE RID: 53438 RVA: 0x00065A2D File Offset: 0x00063C2D
			public unsafe float MaxPitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_MaxPitch)) = value;
				}
			}

			// Token: 0x170040D6 RID: 16598
			// (get) Token: 0x0600D0BF RID: 53439 RVA: 0x00320928 File Offset: 0x0031EB28
			// (set) Token: 0x0600D0C0 RID: 53440 RVA: 0x00065A48 File Offset: 0x00063C48
			public unsafe Il2CppReferenceArray<AudioClip> Clips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.ImpactType.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CDC RID: 36060
			private static readonly IntPtr NativeFieldInfoPtr_Material;

			// Token: 0x04008CDD RID: 36061
			private static readonly IntPtr NativeFieldInfoPtr_MinVolume;

			// Token: 0x04008CDE RID: 36062
			private static readonly IntPtr NativeFieldInfoPtr_MaxVolume;

			// Token: 0x04008CDF RID: 36063
			private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

			// Token: 0x04008CE0 RID: 36064
			private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

			// Token: 0x04008CE1 RID: 36065
			private static readonly IntPtr NativeFieldInfoPtr_Clips;

			// Token: 0x04008CE2 RID: 36066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A62 RID: 2658
		[ObfuscatedName("ScheduleOne.Audio.SFXManager+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0C1 RID: 53441 RVA: 0x00320958 File Offset: 0x0031EB58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SFXManager>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr);
				SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, "material");
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677000);
				SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr, 100677001);
			}

			// Token: 0x0600D0C2 RID: 53442 RVA: 0x003209C0 File Offset: 0x0031EBC0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SFXManager.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0C3 RID: 53443 RVA: 0x003209FC File Offset: 0x0031EBFC
			[CallerCount(0)]
			public unsafe bool _PlayImpactSound_b__0(SFXManager.ImpactType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SFXManager.__c__DisplayClass6_0.NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0C4 RID: 53444 RVA: 0x00065A67 File Offset: 0x00063C67
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D7 RID: 16599
			// (get) Token: 0x0600D0C5 RID: 53445 RVA: 0x00320A4C File Offset: 0x0031EC4C
			// (set) Token: 0x0600D0C6 RID: 53446 RVA: 0x00065A70 File Offset: 0x00063C70
			public unsafe ImpactSoundEntity.EMaterial material
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SFXManager.__c__DisplayClass6_0.NativeFieldInfoPtr_material)) = value;
				}
			}

			// Token: 0x04008CE3 RID: 36067
			private static readonly IntPtr NativeFieldInfoPtr_material;

			// Token: 0x04008CE4 RID: 36068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CE5 RID: 36069
			private static readonly IntPtr NativeMethodInfoPtr__PlayImpactSound_b__0_Internal_Boolean_ImpactType_0;
		}
	}
}
