using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x02000684 RID: 1668
	public class AudioSlider : SettingsSlider
	{
		// Token: 0x06009587 RID: 38279 RVA: 0x0026567C File Offset: 0x0026387C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSlider()
		{
			Il2CppClassPointerStore<AudioSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "AudioSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr);
			AudioSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "MULTIPLIER");
			AudioSlider.NativeFieldInfoPtr_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "Master");
			AudioSlider.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "AudioType");
			AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681779);
			AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681780);
			AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100681781);
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x00265724 File Offset: 0x00263924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268555, XrefRangeEnd = 268564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x00265760 File Offset: 0x00263960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268564, XrefRangeEnd = 268599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x002657AC File Offset: 0x002639AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268599, XrefRangeEnd = 268600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x00048B45 File Offset: 0x00046D45
		public AudioSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600958C RID: 38284 RVA: 0x002657E8 File Offset: 0x002639E8
		// (set) Token: 0x0600958D RID: 38285 RVA: 0x00048B4E File Offset: 0x00046D4E
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600958E RID: 38286 RVA: 0x00265804 File Offset: 0x00263A04
		// (set) Token: 0x0600958F RID: 38287 RVA: 0x00048B5C File Offset: 0x00046D5C
		public unsafe bool Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master)) = value;
			}
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x06009590 RID: 38288 RVA: 0x0026582C File Offset: 0x00263A2C
		// (set) Token: 0x06009591 RID: 38289 RVA: 0x00048B77 File Offset: 0x00046D77
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x040064D6 RID: 25814
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040064D7 RID: 25815
		private static readonly IntPtr NativeFieldInfoPtr_Master;

		// Token: 0x040064D8 RID: 25816
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x040064D9 RID: 25817
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040064DA RID: 25818
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040064DB RID: 25819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
