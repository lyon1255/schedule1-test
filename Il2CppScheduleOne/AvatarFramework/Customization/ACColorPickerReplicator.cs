using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061C RID: 1564
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x06008A37 RID: 35383 RVA: 0x00243EB4 File Offset: 0x002420B4
		// Note: this type is marked as 'beforefieldinit'.
		static ACColorPickerReplicator()
		{
			Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACColorPickerReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr);
			ACColorPickerReplicator.NativeFieldInfoPtr_picker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, "picker");
			ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680483);
			ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr, 100680484);
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x00243F20 File Offset: 0x00242120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253999, XrefRangeEnd = 254004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACColorPickerReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x00243F70 File Offset: 0x00242170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254008, RefRangeEnd = 254009, XrefRangeStart = 254004, XrefRangeEnd = 254008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACColorPickerReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACColorPickerReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACColorPickerReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x00042178 File Offset: 0x00040378
		public ACColorPickerReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06008A3B RID: 35387 RVA: 0x00243FAC File Offset: 0x002421AC
		// (set) Token: 0x06008A3C RID: 35388 RVA: 0x00042181 File Offset: 0x00040381
		public unsafe ColorPicker picker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACColorPickerReplicator.NativeFieldInfoPtr_picker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DCD RID: 24013
		private static readonly IntPtr NativeFieldInfoPtr_picker;

		// Token: 0x04005DCE RID: 24014
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DCF RID: 24015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
