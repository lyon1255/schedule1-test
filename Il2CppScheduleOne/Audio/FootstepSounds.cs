using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004D0 RID: 1232
	public class FootstepSounds : MonoBehaviour
	{
		// Token: 0x06006BEE RID: 27630 RVA: 0x001DFE70 File Offset: 0x001DE070
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepSounds()
		{
			Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "FootstepSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr);
			FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "COOLDOWN_TIME");
			FootstepSounds.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "sources");
			FootstepSounds.NativeFieldInfoPtr_soundGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "soundGroups");
			FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "materialFootstepSounds");
			FootstepSounds.NativeFieldInfoPtr_lastStepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "lastStepTime");
			FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676936);
			FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676937);
			FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676938);
			FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676939);
			FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100676940);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x001DFF68 File Offset: 0x001DE168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216310, XrefRangeEnd = 216397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x001DFF9C File Offset: 0x001DE19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216397, XrefRangeEnd = 216398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x001DFFD0 File Offset: 0x001DE1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216398, XrefRangeEnd = 216447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Step(EMaterialType materialType, float hardness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref materialType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hardness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x001E001C File Offset: 0x001DE21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216447, XrefRangeEnd = 216465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetFreeSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x001E005C File Offset: 0x001DE25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216465, XrefRangeEnd = 216487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepSounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x00033171 File Offset: 0x00031371
		public FootstepSounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002073 RID: 8307
		// (get) Token: 0x06006BF5 RID: 27637 RVA: 0x001E0098 File Offset: 0x001DE298
		// (set) Token: 0x06006BF6 RID: 27638 RVA: 0x0003317A File Offset: 0x0003137A
		public unsafe static float COOLDOWN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002074 RID: 8308
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x001E00B4 File Offset: 0x001DE2B4
		// (set) Token: 0x06006BF8 RID: 27640 RVA: 0x00033188 File Offset: 0x00031388
		public unsafe List<AudioSourceController> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002075 RID: 8309
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x001E00E4 File Offset: 0x001DE2E4
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x000331A7 File Offset: 0x000313A7
		public unsafe List<FootstepSounds.FootstepSoundGroup> soundGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002076 RID: 8310
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x001E0114 File Offset: 0x001DE314
		// (set) Token: 0x06006BFC RID: 27644 RVA: 0x000331C6 File Offset: 0x000313C6
		public unsafe Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002077 RID: 8311
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x001E0144 File Offset: 0x001DE344
		// (set) Token: 0x06006BFE RID: 27646 RVA: 0x000331E5 File Offset: 0x000313E5
		public unsafe float lastStepTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime)) = value;
			}
		}

		// Token: 0x040049D3 RID: 18899
		private static readonly IntPtr NativeFieldInfoPtr_COOLDOWN_TIME;

		// Token: 0x040049D4 RID: 18900
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x040049D5 RID: 18901
		private static readonly IntPtr NativeFieldInfoPtr_soundGroups;

		// Token: 0x040049D6 RID: 18902
		private static readonly IntPtr NativeFieldInfoPtr_materialFootstepSounds;

		// Token: 0x040049D7 RID: 18903
		private static readonly IntPtr NativeFieldInfoPtr_lastStepTime;

		// Token: 0x040049D8 RID: 18904
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040049D9 RID: 18905
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040049DA RID: 18906
		private static readonly IntPtr NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0;

		// Token: 0x040049DB RID: 18907
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0;

		// Token: 0x040049DC RID: 18908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5B RID: 2651
		[Serializable]
		public class FootstepSoundGroup : Il2CppSystem.Object
		{
			// Token: 0x0600D089 RID: 53385 RVA: 0x003200D4 File Offset: 0x0031E2D4
			// Note: this type is marked as 'beforefieldinit'.
			static FootstepSoundGroup()
			{
				Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "FootstepSoundGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr);
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "name");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "clips");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "appliesTo");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMin");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMax");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "Volume");
				FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, 100676941);
			}

			// Token: 0x0600D08A RID: 53386 RVA: 0x0032018C File Offset: 0x0031E38C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216277, XrefRangeEnd = 216292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootstepSoundGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D08B RID: 53387 RVA: 0x0006585C File Offset: 0x00063A5C
			public FootstepSoundGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C6 RID: 16582
			// (get) Token: 0x0600D08C RID: 53388 RVA: 0x003201C8 File Offset: 0x0031E3C8
			// (set) Token: 0x0600D08D RID: 53389 RVA: 0x00065865 File Offset: 0x00063A65
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040C7 RID: 16583
			// (get) Token: 0x0600D08E RID: 53390 RVA: 0x003201F0 File Offset: 0x0031E3F0
			// (set) Token: 0x0600D08F RID: 53391 RVA: 0x00065884 File Offset: 0x00063A84
			public unsafe List<AudioClip> clips
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C8 RID: 16584
			// (get) Token: 0x0600D090 RID: 53392 RVA: 0x00320220 File Offset: 0x0031E420
			// (set) Token: 0x0600D091 RID: 53393 RVA: 0x000658A3 File Offset: 0x00063AA3
			public unsafe List<FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup.MaterialType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C9 RID: 16585
			// (get) Token: 0x0600D092 RID: 53394 RVA: 0x00320250 File Offset: 0x0031E450
			// (set) Token: 0x0600D093 RID: 53395 RVA: 0x000658C2 File Offset: 0x00063AC2
			public unsafe float PitchMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin)) = value;
				}
			}

			// Token: 0x170040CA RID: 16586
			// (get) Token: 0x0600D094 RID: 53396 RVA: 0x00320278 File Offset: 0x0031E478
			// (set) Token: 0x0600D095 RID: 53397 RVA: 0x000658DD File Offset: 0x00063ADD
			public unsafe float PitchMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax)) = value;
				}
			}

			// Token: 0x170040CB RID: 16587
			// (get) Token: 0x0600D096 RID: 53398 RVA: 0x003202A0 File Offset: 0x0031E4A0
			// (set) Token: 0x0600D097 RID: 53399 RVA: 0x000658F8 File Offset: 0x00063AF8
			public unsafe float Volume
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x04008CBD RID: 36029
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04008CBE RID: 36030
			private static readonly IntPtr NativeFieldInfoPtr_clips;

			// Token: 0x04008CBF RID: 36031
			private static readonly IntPtr NativeFieldInfoPtr_appliesTo;

			// Token: 0x04008CC0 RID: 36032
			private static readonly IntPtr NativeFieldInfoPtr_PitchMin;

			// Token: 0x04008CC1 RID: 36033
			private static readonly IntPtr NativeFieldInfoPtr_PitchMax;

			// Token: 0x04008CC2 RID: 36034
			private static readonly IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x04008CC3 RID: 36035
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C5D RID: 3165
			[Serializable]
			public class MaterialType : Il2CppSystem.Object
			{
				// Token: 0x0600E3DC RID: 58332 RVA: 0x0035750C File Offset: 0x0035570C
				// Note: this type is marked as 'beforefieldinit'.
				static MaterialType()
				{
					Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "MaterialType");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr);
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, "type");
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, 100676942);
				}

				// Token: 0x0600E3DD RID: 58333 RVA: 0x00357560 File Offset: 0x00355760
				[CallerCount(2259)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MaterialType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3DE RID: 58334 RVA: 0x0006F121 File Offset: 0x0006D321
				public MaterialType(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046BB RID: 18107
				// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x0035759C File Offset: 0x0035579C
				// (set) Token: 0x0600E3E0 RID: 58336 RVA: 0x0006F12A File Offset: 0x0006D32A
				public unsafe EMaterialType type
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type)) = value;
					}
				}

				// Token: 0x04009874 RID: 39028
				private static readonly IntPtr NativeFieldInfoPtr_type;

				// Token: 0x04009875 RID: 39029
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000A5C RID: 2652
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D098 RID: 53400 RVA: 0x003202C8 File Offset: 0x0031E4C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr);
				FootstepSounds.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9");
				FootstepSounds.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9__9_0");
				FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100676944);
				FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100676945);
			}

			// Token: 0x0600D099 RID: 53401 RVA: 0x00320344 File Offset: 0x0031E544
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D09A RID: 53402 RVA: 0x00320380 File Offset: 0x0031E580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216292, XrefRangeEnd = 216293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeSource_b__9_0(AudioSourceController source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D09B RID: 53403 RVA: 0x00065913 File Offset: 0x00063B13
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CC RID: 16588
			// (get) Token: 0x0600D09C RID: 53404 RVA: 0x003203D0 File Offset: 0x0031E5D0
			// (set) Token: 0x0600D09D RID: 53405 RVA: 0x0006591C File Offset: 0x00063B1C
			public unsafe static FootstepSounds.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040CD RID: 16589
			// (get) Token: 0x0600D09E RID: 53406 RVA: 0x003203F8 File Offset: 0x0031E5F8
			// (set) Token: 0x0600D09F RID: 53407 RVA: 0x0006592E File Offset: 0x00063B2E
			public unsafe static Func<AudioSourceController, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CC4 RID: 36036
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CC5 RID: 36037
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008CC6 RID: 36038
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CC7 RID: 36039
			private static readonly IntPtr NativeMethodInfoPtr__GetFreeSource_b__9_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x02000A5D RID: 2653
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0A0 RID: 53408 RVA: 0x00320420 File Offset: 0x0031E620
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr);
				FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, "source");
				FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, 100676946);
				FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, 100676947);
			}

			// Token: 0x0600D0A1 RID: 53409 RVA: 0x00320488 File Offset: 0x0031E688
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0A2 RID: 53410 RVA: 0x003204C4 File Offset: 0x0031E6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216305, XrefRangeEnd = 216310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D0A3 RID: 53411 RVA: 0x00065940 File Offset: 0x00063B40
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040CE RID: 16590
			// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x00320504 File Offset: 0x0031E704
			// (set) Token: 0x0600D0A5 RID: 53413 RVA: 0x00065949 File Offset: 0x00063B49
			public unsafe AudioSourceController source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CC8 RID: 36040
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04008CC9 RID: 36041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CCA RID: 36042
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5E RID: 3166
			[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass8_0+<<Step>g__DisableSource|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3E1 RID: 58337 RVA: 0x003575C4 File Offset: 0x003557C4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0>.NativeClassPtr, "<<Step>g__DisableSource|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676948);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676949);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676950);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676951);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676952);
					FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676953);
				}

				// Token: 0x0600E3E2 RID: 58338 RVA: 0x003576A4 File Offset: 0x003558A4
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3E3 RID: 58339 RVA: 0x003576EC File Offset: 0x003558EC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3E4 RID: 58340 RVA: 0x00357720 File Offset: 0x00355920
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216293, XrefRangeEnd = 216300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046BF RID: 18111
				// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x0035775C File Offset: 0x0035595C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3E6 RID: 58342 RVA: 0x0035779C File Offset: 0x0035599C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216300, XrefRangeEnd = 216305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046C0 RID: 18112
				// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x003577D0 File Offset: 0x003559D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3E8 RID: 58344 RVA: 0x0006F145 File Offset: 0x0006D345
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046BC RID: 18108
				// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x00357810 File Offset: 0x00355A10
				// (set) Token: 0x0600E3EA RID: 58346 RVA: 0x0006F14E File Offset: 0x0006D34E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046BD RID: 18109
				// (get) Token: 0x0600E3EB RID: 58347 RVA: 0x00357838 File Offset: 0x00355A38
				// (set) Token: 0x0600E3EC RID: 58348 RVA: 0x0006F169 File Offset: 0x0006D369
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046BE RID: 18110
				// (get) Token: 0x0600E3ED RID: 58349 RVA: 0x00357868 File Offset: 0x00355A68
				// (set) Token: 0x0600E3EE RID: 58350 RVA: 0x0006F188 File Offset: 0x0006D388
				public unsafe FootstepSounds.__c__DisplayClass8_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c__DisplayClass8_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass8_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009876 RID: 39030
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009877 RID: 39031
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009878 RID: 39032
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009879 RID: 39033
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400987A RID: 39034
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400987B RID: 39035
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400987C RID: 39036
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400987D RID: 39037
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400987E RID: 39038
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
