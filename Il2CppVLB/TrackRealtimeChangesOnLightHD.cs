using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x0200009A RID: 154
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x0008EDB4 File Offset: 0x0008CFB4
		// Note: this type is marked as 'beforefieldinit'.
		static TrackRealtimeChangesOnLightHD()
		{
			Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "TrackRealtimeChangesOnLightHD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr);
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "ClassName");
			TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, "m_Master");
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664376);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664377);
			TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr, 100664378);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0008EE48 File Offset: 0x0008D048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80846, XrefRangeEnd = 80850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0008EE7C File Offset: 0x0008D07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80850, XrefRangeEnd = 80852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0008EEB0 File Offset: 0x0008D0B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackRealtimeChangesOnLightHD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackRealtimeChangesOnLightHD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackRealtimeChangesOnLightHD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00007413 File Offset: 0x00005613
		public TrackRealtimeChangesOnLightHD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0008EEEC File Offset: 0x0008D0EC
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0000741C File Offset: 0x0000561C
		public unsafe static string ClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_ClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0008EF0C File Offset: 0x0008D10C
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x0000742E File Offset: 0x0000562E
		public unsafe VolumetricLightBeamHD m_Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamHD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackRealtimeChangesOnLightHD.NativeFieldInfoPtr_m_Master), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeFieldInfoPtr_m_Master;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
