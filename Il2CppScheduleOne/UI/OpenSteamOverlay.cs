using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000621 RID: 1569
	public class OpenSteamOverlay : MonoBehaviour
	{
		// Token: 0x06008A63 RID: 35427 RVA: 0x0024459C File Offset: 0x0024279C
		// Note: this type is marked as 'beforefieldinit'.
		static OpenSteamOverlay()
		{
			Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "OpenSteamOverlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr);
			OpenSteamOverlay.NativeFieldInfoPtr_APP_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "APP_ID");
			OpenSteamOverlay.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "Type");
			OpenSteamOverlay.NativeFieldInfoPtr_CustomLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, "CustomLink");
			OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680493);
			OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr, 100680494);
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00244630 File Offset: 0x00242830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254054, XrefRangeEnd = 254057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenOverlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr_OpenOverlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x00244664 File Offset: 0x00242864
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpenSteamOverlay() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpenSteamOverlay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpenSteamOverlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x00042336 File Offset: 0x00040536
		public OpenSteamOverlay(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x002446A0 File Offset: 0x002428A0
		// (set) Token: 0x06008A68 RID: 35432 RVA: 0x0004233F File Offset: 0x0004053F
		public unsafe static uint APP_ID
		{
			get
			{
				uint result;
				IL2CPP.il2cpp_field_static_get_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OpenSteamOverlay.NativeFieldInfoPtr_APP_ID, (void*)(&value));
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x002446BC File Offset: 0x002428BC
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x0004234D File Offset: 0x0004054D
		public unsafe OpenSteamOverlay.EType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x002446E4 File Offset: 0x002428E4
		// (set) Token: 0x06008A6C RID: 35436 RVA: 0x00042368 File Offset: 0x00040568
		public unsafe string CustomLink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpenSteamOverlay.NativeFieldInfoPtr_CustomLink), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005DE3 RID: 24035
		private static readonly IntPtr NativeFieldInfoPtr_APP_ID;

		// Token: 0x04005DE4 RID: 24036
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04005DE5 RID: 24037
		private static readonly IntPtr NativeFieldInfoPtr_CustomLink;

		// Token: 0x04005DE6 RID: 24038
		private static readonly IntPtr NativeMethodInfoPtr_OpenOverlay_Public_Void_0;

		// Token: 0x04005DE7 RID: 24039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B10 RID: 2832
		[OriginalName("Assembly-CSharp.dll", "", "EType")]
		public enum EType
		{
			// Token: 0x04009051 RID: 36945
			Store,
			// Token: 0x04009052 RID: 36946
			CustomLink
		}
	}
}
