using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061F RID: 1567
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x06008A47 RID: 35399 RVA: 0x00244180 File Offset: 0x00242380
		// Note: this type is marked as 'beforefieldinit'.
		static ACSliderReplicator()
		{
			Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACSliderReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr);
			ACSliderReplicator.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, "slider");
			ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680489);
			ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr, 100680490);
		}

		// Token: 0x06008A48 RID: 35400 RVA: 0x002441EC File Offset: 0x002423EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254038, XrefRangeEnd = 254044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACSliderReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x0024423C File Offset: 0x0024243C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254008, RefRangeEnd = 254009, XrefRangeStart = 254008, XrefRangeEnd = 254009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACSliderReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACSliderReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACSliderReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x0004220A File Offset: 0x0004040A
		public ACSliderReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x00244278 File Offset: 0x00242478
		// (set) Token: 0x06008A4C RID: 35404 RVA: 0x00042213 File Offset: 0x00040413
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACSliderReplicator.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DD5 RID: 24021
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04005DD6 RID: 24022
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DD7 RID: 24023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
