using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x02000607 RID: 1543
	[Serializable]
	public class AvatarEmotionPreset : Il2CppSystem.Object
	{
		// Token: 0x06008810 RID: 34832 RVA: 0x0023D91C File Offset: 0x0023BB1C
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionPreset()
		{
			Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr);
			AvatarEmotionPreset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "PresetName");
			AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "FaceTexture");
			AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "LeftEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "RightEyeRestingState");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowAngleChange_R");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_L");
			AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, "BrowHeightChange_R");
			AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680276);
			AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr, 100680277);
		}

		// Token: 0x06008811 RID: 34833 RVA: 0x0023DA14 File Offset: 0x0023BC14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252053, RefRangeEnd = 252055, XrefRangeStart = 252029, XrefRangeEnd = 252053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(end);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(neutralPreset);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr3) : null;
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x0023DA8C File Offset: 0x0023BC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252055, XrefRangeEnd = 252060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionPreset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x00040D9B File Offset: 0x0003EF9B
		public AvatarEmotionPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06008814 RID: 34836 RVA: 0x0023DAC8 File Offset: 0x0023BCC8
		// (set) Token: 0x06008815 RID: 34837 RVA: 0x00040DA4 File Offset: 0x0003EFA4
		public unsafe string PresetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06008816 RID: 34838 RVA: 0x0023DAF0 File Offset: 0x0023BCF0
		// (set) Token: 0x06008817 RID: 34839 RVA: 0x00040DC3 File Offset: 0x0003EFC3
		public unsafe Texture2D FaceTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_FaceTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06008818 RID: 34840 RVA: 0x0023DB20 File Offset: 0x0023BD20
		// (set) Token: 0x06008819 RID: 34841 RVA: 0x00040DE2 File Offset: 0x0003EFE2
		public unsafe Eye.EyeLidConfiguration LeftEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_LeftEyeRestingState)) = value;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600881A RID: 34842 RVA: 0x0023DB48 File Offset: 0x0023BD48
		// (set) Token: 0x0600881B RID: 34843 RVA: 0x00040DFD File Offset: 0x0003EFFD
		public unsafe Eye.EyeLidConfiguration RightEyeRestingState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_RightEyeRestingState)) = value;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x0023DB70 File Offset: 0x0023BD70
		// (set) Token: 0x0600881D RID: 34845 RVA: 0x00040E18 File Offset: 0x0003F018
		public unsafe float BrowAngleChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_L)) = value;
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x0023DB98 File Offset: 0x0023BD98
		// (set) Token: 0x0600881F RID: 34847 RVA: 0x00040E33 File Offset: 0x0003F033
		public unsafe float BrowAngleChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowAngleChange_R)) = value;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x0023DBC0 File Offset: 0x0023BDC0
		// (set) Token: 0x06008821 RID: 34849 RVA: 0x00040E4E File Offset: 0x0003F04E
		public unsafe float BrowHeightChange_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_L)) = value;
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x0023DBE8 File Offset: 0x0023BDE8
		// (set) Token: 0x06008823 RID: 34851 RVA: 0x00040E69 File Offset: 0x0003F069
		public unsafe float BrowHeightChange_R
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionPreset.NativeFieldInfoPtr_BrowHeightChange_R)) = value;
			}
		}

		// Token: 0x04005C7B RID: 23675
		private static readonly IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04005C7C RID: 23676
		private static readonly IntPtr NativeFieldInfoPtr_FaceTexture;

		// Token: 0x04005C7D RID: 23677
		private static readonly IntPtr NativeFieldInfoPtr_LeftEyeRestingState;

		// Token: 0x04005C7E RID: 23678
		private static readonly IntPtr NativeFieldInfoPtr_RightEyeRestingState;

		// Token: 0x04005C7F RID: 23679
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_L;

		// Token: 0x04005C80 RID: 23680
		private static readonly IntPtr NativeFieldInfoPtr_BrowAngleChange_R;

		// Token: 0x04005C81 RID: 23681
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_L;

		// Token: 0x04005C82 RID: 23682
		private static readonly IntPtr NativeFieldInfoPtr_BrowHeightChange_R;

		// Token: 0x04005C83 RID: 23683
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_AvatarEmotionPreset_Single_0;

		// Token: 0x04005C84 RID: 23684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
