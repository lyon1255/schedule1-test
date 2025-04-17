using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046F RID: 1135
	[Serializable]
	public class AudioSettings : Object
	{
		// Token: 0x0600623D RID: 25149 RVA: 0x001BEFD8 File Offset: 0x001BD1D8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MasterVolume");
			AudioSettings.NativeFieldInfoPtr_AmbientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AmbientVolume");
			AudioSettings.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MusicVolume");
			AudioSettings.NativeFieldInfoPtr_SFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "SFXVolume");
			AudioSettings.NativeFieldInfoPtr_UIVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "UIVolume");
			AudioSettings.NativeFieldInfoPtr_DialogueVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "DialogueVolume");
			AudioSettings.NativeFieldInfoPtr_FootstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "FootstepsVolume");
			AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100675765);
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x001BF0A8 File Offset: 0x001BD2A8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x0002E6A8 File Offset: 0x0002C8A8
		public AudioSettings(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x06006240 RID: 25152 RVA: 0x001BF0E4 File Offset: 0x001BD2E4
		// (set) Token: 0x06006241 RID: 25153 RVA: 0x0002E6B1 File Offset: 0x0002C8B1
		public unsafe float MasterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume)) = value;
			}
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06006242 RID: 25154 RVA: 0x001BF10C File Offset: 0x001BD30C
		// (set) Token: 0x06006243 RID: 25155 RVA: 0x0002E6CC File Offset: 0x0002C8CC
		public unsafe float AmbientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume)) = value;
			}
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06006244 RID: 25156 RVA: 0x001BF134 File Offset: 0x001BD334
		// (set) Token: 0x06006245 RID: 25157 RVA: 0x0002E6E7 File Offset: 0x0002C8E7
		public unsafe float MusicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume)) = value;
			}
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06006246 RID: 25158 RVA: 0x001BF15C File Offset: 0x001BD35C
		// (set) Token: 0x06006247 RID: 25159 RVA: 0x0002E702 File Offset: 0x0002C902
		public unsafe float SFXVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume)) = value;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06006248 RID: 25160 RVA: 0x001BF184 File Offset: 0x001BD384
		// (set) Token: 0x06006249 RID: 25161 RVA: 0x0002E71D File Offset: 0x0002C91D
		public unsafe float UIVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume)) = value;
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x0600624A RID: 25162 RVA: 0x001BF1AC File Offset: 0x001BD3AC
		// (set) Token: 0x0600624B RID: 25163 RVA: 0x0002E738 File Offset: 0x0002C938
		public unsafe float DialogueVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume)) = value;
			}
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x0600624C RID: 25164 RVA: 0x001BF1D4 File Offset: 0x001BD3D4
		// (set) Token: 0x0600624D RID: 25165 RVA: 0x0002E753 File Offset: 0x0002C953
		public unsafe float FootstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume)) = value;
			}
		}

		// Token: 0x040042FB RID: 17147
		private static readonly IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x040042FC RID: 17148
		private static readonly IntPtr NativeFieldInfoPtr_AmbientVolume;

		// Token: 0x040042FD RID: 17149
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x040042FE RID: 17150
		private static readonly IntPtr NativeFieldInfoPtr_SFXVolume;

		// Token: 0x040042FF RID: 17151
		private static readonly IntPtr NativeFieldInfoPtr_UIVolume;

		// Token: 0x04004300 RID: 17152
		private static readonly IntPtr NativeFieldInfoPtr_DialogueVolume;

		// Token: 0x04004301 RID: 17153
		private static readonly IntPtr NativeFieldInfoPtr_FootstepsVolume;

		// Token: 0x04004302 RID: 17154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
