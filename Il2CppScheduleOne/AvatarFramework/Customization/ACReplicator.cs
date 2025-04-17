﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061E RID: 1566
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x06008A40 RID: 35392 RVA: 0x00244018 File Offset: 0x00242218
		// Note: this type is marked as 'beforefieldinit'.
		static ACReplicator()
		{
			Il2CppClassPointerStore<ACReplicator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACReplicator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr);
			ACReplicator.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, "propertyName");
			ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680486);
			ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680487);
			ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr, 100680488);
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x00244098 File Offset: 0x00242298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254012, XrefRangeEnd = 254038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x002440CC File Offset: 0x002422CC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACReplicator.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x0024411C File Offset: 0x0024231C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254008, RefRangeEnd = 254009, XrefRangeStart = 254008, XrefRangeEnd = 254009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACReplicator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACReplicator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x000421E2 File Offset: 0x000403E2
		public ACReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x00244158 File Offset: 0x00242358
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x000421EB File Offset: 0x000403EB
		public unsafe string propertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACReplicator.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005DD1 RID: 24017
		private static readonly IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04005DD2 RID: 24018
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005DD3 RID: 24019
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_New_Void_AvatarSettings_0;

		// Token: 0x04005DD4 RID: 24020
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
