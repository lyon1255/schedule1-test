using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054D RID: 1357
	public class SetLayerOnAwake : MonoBehaviour
	{
		// Token: 0x060077C3 RID: 30659 RVA: 0x00207090 File Offset: 0x00205290
		// Note: this type is marked as 'beforefieldinit'.
		static SetLayerOnAwake()
		{
			Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "SetLayerOnAwake");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr);
			SetLayerOnAwake.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, "Layer");
			SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678367);
			SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr, 100678368);
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x002070FC File Offset: 0x002052FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231911, XrefRangeEnd = 231915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x00207130 File Offset: 0x00205330
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetLayerOnAwake() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLayerOnAwake>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetLayerOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00038B84 File Offset: 0x00036D84
		public SetLayerOnAwake(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x0020716C File Offset: 0x0020536C
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x00038B8D File Offset: 0x00036D8D
		public unsafe LayerMask Layer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetLayerOnAwake.NativeFieldInfoPtr_Layer)) = value;
			}
		}

		// Token: 0x040051B2 RID: 20914
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x040051B3 RID: 20915
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051B4 RID: 20916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
