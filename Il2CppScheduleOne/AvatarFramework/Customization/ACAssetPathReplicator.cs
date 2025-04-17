using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200061A RID: 1562
	public class ACAssetPathReplicator<T> : ACReplicator where T : UnityEngine.Object
	{
		// Token: 0x06008A2D RID: 35373 RVA: 0x00243CC4 File Offset: 0x00241EC4
		// Note: this type is marked as 'beforefieldinit'.
		static ACAssetPathReplicator()
		{
			Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACAssetPathReplicator`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr);
			ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, "selection");
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680479);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680480);
			ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr, 100680481);
		}

		// Token: 0x06008A2E RID: 35374 RVA: 0x00243D80 File Offset: 0x00241F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253984, XrefRangeEnd = 253987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A2F RID: 35375 RVA: 0x00243DBC File Offset: 0x00241FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253987, XrefRangeEnd = 253992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACAssetPathReplicator<T>.NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A30 RID: 35376 RVA: 0x00243E0C File Offset: 0x0024200C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253993, RefRangeEnd = 253996, XrefRangeStart = 253992, XrefRangeEnd = 253993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACAssetPathReplicator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACAssetPathReplicator<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACAssetPathReplicator<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A31 RID: 35377 RVA: 0x0004210E File Offset: 0x0004030E
		public ACAssetPathReplicator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06008A32 RID: 35378 RVA: 0x00243E48 File Offset: 0x00242048
		// (set) Token: 0x06008A33 RID: 35379 RVA: 0x00042117 File Offset: 0x00040317
		public unsafe ACSelection<T> selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ACSelection<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ACAssetPathReplicator<T>.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005DC8 RID: 24008
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04005DC9 RID: 24009
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005DCA RID: 24010
		private static readonly IntPtr NativeMethodInfoPtr_AvatarSettingsChanged_Protected_Virtual_Void_AvatarSettings_0;

		// Token: 0x04005DCB RID: 24011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
