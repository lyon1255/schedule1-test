using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200014B RID: 331
	public class CharacterGeneratorSettings : ScriptableObject
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x000C6310 File Offset: 0x000C4510
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterGeneratorSettings()
		{
			Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterGeneratorSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr);
			CharacterGeneratorSettings.NativeFieldInfoPtr_hair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hair");
			CharacterGeneratorSettings.NativeFieldInfoPtr_beard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "beard");
			CharacterGeneratorSettings.NativeFieldInfoPtr_hat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hat");
			CharacterGeneratorSettings.NativeFieldInfoPtr_accessory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "accessory");
			CharacterGeneratorSettings.NativeFieldInfoPtr_shirt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "shirt");
			CharacterGeneratorSettings.NativeFieldInfoPtr_pants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "pants");
			CharacterGeneratorSettings.NativeFieldInfoPtr_shoes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "shoes");
			CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "skinColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "eyeColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "hairColors");
			CharacterGeneratorSettings.NativeFieldInfoPtr_headSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "headSize");
			CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "headOffset");
			CharacterGeneratorSettings.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "height");
			CharacterGeneratorSettings.NativeFieldInfoPtr_fat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "fat");
			CharacterGeneratorSettings.NativeFieldInfoPtr_muscles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "muscles");
			CharacterGeneratorSettings.NativeFieldInfoPtr_thin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "thin");
			CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "facialBlendshapes");
			CharacterGeneratorSettings.NativeFieldInfoPtr_excludes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, "excludes");
			CharacterGeneratorSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr, 100666223);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000C64BC File Offset: 0x000C46BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100418, XrefRangeEnd = 100446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterGeneratorSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGeneratorSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterGeneratorSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0000F767 File Offset: 0x0000D967
		public CharacterGeneratorSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x000C64F8 File Offset: 0x000C46F8
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0000F770 File Offset: 0x0000D970
		public unsafe MinMaxIndex hair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x000C6528 File Offset: 0x000C4728
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0000F78F File Offset: 0x0000D98F
		public unsafe MinMaxIndex beard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_beard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_beard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x000C6558 File Offset: 0x000C4758
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000F7AE File Offset: 0x0000D9AE
		public unsafe MinMaxIndex hat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x000C6588 File Offset: 0x000C4788
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000F7CD File Offset: 0x0000D9CD
		public unsafe MinMaxIndex accessory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_accessory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_accessory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x000C65B8 File Offset: 0x000C47B8
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		public unsafe MinMaxIndex shirt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shirt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shirt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x000C65E8 File Offset: 0x000C47E8
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000F80B File Offset: 0x0000DA0B
		public unsafe MinMaxIndex pants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_pants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_pants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x000C6618 File Offset: 0x000C4818
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000F82A File Offset: 0x0000DA2A
		public unsafe MinMaxIndex shoes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shoes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxIndex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_shoes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000C6648 File Offset: 0x000C4848
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000F849 File Offset: 0x0000DA49
		public unsafe MinMaxColor skinColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_skinColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000C6678 File Offset: 0x000C4878
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000F868 File Offset: 0x0000DA68
		public unsafe MinMaxColor eyeColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_eyeColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x000C66A8 File Offset: 0x000C48A8
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0000F887 File Offset: 0x0000DA87
		public unsafe MinMaxColor hairColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_hairColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000C66D8 File Offset: 0x000C48D8
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x0000F8A6 File Offset: 0x0000DAA6
		public unsafe MinMaxBlendshapes headSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000C6708 File Offset: 0x000C4908
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x0000F8C5 File Offset: 0x0000DAC5
		public unsafe MinMaxBlendshapes headOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_headOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x000C6738 File Offset: 0x000C4938
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0000F8E4 File Offset: 0x0000DAE4
		public unsafe MinMaxBlendshapes height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_height);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_height), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x000C6768 File Offset: 0x000C4968
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x0000F903 File Offset: 0x0000DB03
		public unsafe MinMaxBlendshapes fat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_fat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_fat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x000C6798 File Offset: 0x000C4998
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0000F922 File Offset: 0x0000DB22
		public unsafe MinMaxBlendshapes muscles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_muscles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_muscles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x000C67C8 File Offset: 0x000C49C8
		// (set) Token: 0x06001B86 RID: 7046 RVA: 0x0000F941 File Offset: 0x0000DB41
		public unsafe MinMaxBlendshapes thin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_thin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinMaxBlendshapes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_thin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x000C67F8 File Offset: 0x000C49F8
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0000F960 File Offset: 0x0000DB60
		public unsafe List<MinMaxFacialBlendshapes> facialBlendshapes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MinMaxFacialBlendshapes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_facialBlendshapes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x000C6828 File Offset: 0x000C4A28
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x0000F97F File Offset: 0x0000DB7F
		public unsafe List<GeneratorExclude> excludes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_excludes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GeneratorExclude>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterGeneratorSettings.NativeFieldInfoPtr_excludes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_hair;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_beard;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_hat;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_accessory;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_shirt;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeFieldInfoPtr_pants;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeFieldInfoPtr_shoes;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeFieldInfoPtr_skinColors;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeFieldInfoPtr_eyeColors;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeFieldInfoPtr_hairColors;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeFieldInfoPtr_headSize;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeFieldInfoPtr_headOffset;

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_fat;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_muscles;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr_thin;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeFieldInfoPtr_facialBlendshapes;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr_excludes;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
