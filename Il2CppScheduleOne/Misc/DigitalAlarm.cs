using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000767 RID: 1895
	public class DigitalAlarm : MonoBehaviour
	{
		// Token: 0x0600B3E6 RID: 46054 RVA: 0x002CD400 File Offset: 0x002CB600
		// Note: this type is marked as 'beforefieldinit'.
		static DigitalAlarm()
		{
			Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "DigitalAlarm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr);
			DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FLASH_FREQUENCY");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMesh");
			DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenMeshMaterialIndex");
			DigitalAlarm.NativeFieldInfoPtr_ScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenText");
			DigitalAlarm.NativeFieldInfoPtr_FlashScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "FlashScreen");
			DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "DisplayCurrentTime");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOffMat");
			DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, "ScreenOnMat");
			DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685462);
			DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685463);
			DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685464);
			DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685465);
			DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685466);
			DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685467);
			DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685468);
			DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr, 100685469);
		}

		// Token: 0x0600B3E7 RID: 46055 RVA: 0x002CD570 File Offset: 0x002CB770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308684, XrefRangeEnd = 308702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3E8 RID: 46056 RVA: 0x002CD5A4 File Offset: 0x002CB7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308702, XrefRangeEnd = 308724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3E9 RID: 46057 RVA: 0x002CD5D8 File Offset: 0x002CB7D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 308733, RefRangeEnd = 308739, XrefRangeStart = 308724, XrefRangeEnd = 308733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreenLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3EA RID: 46058 RVA: 0x002CD618 File Offset: 0x002CB818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308740, RefRangeEnd = 308742, XrefRangeStart = 308739, XrefRangeEnd = 308740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3EB RID: 46059 RVA: 0x002CD65C File Offset: 0x002CB85C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308750, RefRangeEnd = 308754, XrefRangeStart = 308742, XrefRangeEnd = 308750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayMinutes(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3EC RID: 46060 RVA: 0x002CD69C File Offset: 0x002CB89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308754, XrefRangeEnd = 308759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3ED RID: 46061 RVA: 0x002CD6D0 File Offset: 0x002CB8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308759, XrefRangeEnd = 308766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3EE RID: 46062 RVA: 0x002CD704 File Offset: 0x002CB904
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DigitalAlarm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DigitalAlarm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DigitalAlarm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3EF RID: 46063 RVA: 0x000582FB File Offset: 0x000564FB
		public DigitalAlarm(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600B3F0 RID: 46064 RVA: 0x002CD740 File Offset: 0x002CB940
		// (set) Token: 0x0600B3F1 RID: 46065 RVA: 0x00058304 File Offset: 0x00056504
		public unsafe static float FLASH_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DigitalAlarm.NativeFieldInfoPtr_FLASH_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600B3F2 RID: 46066 RVA: 0x002CD75C File Offset: 0x002CB95C
		// (set) Token: 0x0600B3F3 RID: 46067 RVA: 0x00058312 File Offset: 0x00056512
		public unsafe MeshRenderer ScreenMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600B3F4 RID: 46068 RVA: 0x002CD78C File Offset: 0x002CB98C
		// (set) Token: 0x0600B3F5 RID: 46069 RVA: 0x00058331 File Offset: 0x00056531
		public unsafe int ScreenMeshMaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenMeshMaterialIndex)) = value;
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x002CD7B4 File Offset: 0x002CB9B4
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x0005834C File Offset: 0x0005654C
		public unsafe TextMeshPro ScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x002CD7E4 File Offset: 0x002CB9E4
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x0005836B File Offset: 0x0005656B
		public unsafe bool FlashScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_FlashScreen)) = value;
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x002CD80C File Offset: 0x002CBA0C
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x00058386 File Offset: 0x00056586
		public unsafe bool DisplayCurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_DisplayCurrentTime)) = value;
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x002CD834 File Offset: 0x002CBA34
		// (set) Token: 0x0600B3FD RID: 46077 RVA: 0x000583A1 File Offset: 0x000565A1
		public unsafe Material ScreenOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x002CD864 File Offset: 0x002CBA64
		// (set) Token: 0x0600B3FF RID: 46079 RVA: 0x000583C0 File Offset: 0x000565C0
		public unsafe Material ScreenOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DigitalAlarm.NativeFieldInfoPtr_ScreenOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400794F RID: 31055
		private static readonly IntPtr NativeFieldInfoPtr_FLASH_FREQUENCY;

		// Token: 0x04007950 RID: 31056
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMesh;

		// Token: 0x04007951 RID: 31057
		private static readonly IntPtr NativeFieldInfoPtr_ScreenMeshMaterialIndex;

		// Token: 0x04007952 RID: 31058
		private static readonly IntPtr NativeFieldInfoPtr_ScreenText;

		// Token: 0x04007953 RID: 31059
		private static readonly IntPtr NativeFieldInfoPtr_FlashScreen;

		// Token: 0x04007954 RID: 31060
		private static readonly IntPtr NativeFieldInfoPtr_DisplayCurrentTime;

		// Token: 0x04007955 RID: 31061
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOffMat;

		// Token: 0x04007956 RID: 31062
		private static readonly IntPtr NativeFieldInfoPtr_ScreenOnMat;

		// Token: 0x04007957 RID: 31063
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007958 RID: 31064
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007959 RID: 31065
		private static readonly IntPtr NativeMethodInfoPtr_SetScreenLit_Public_Void_Boolean_0;

		// Token: 0x0400795A RID: 31066
		private static readonly IntPtr NativeMethodInfoPtr_DisplayText_Public_Void_String_0;

		// Token: 0x0400795B RID: 31067
		private static readonly IntPtr NativeMethodInfoPtr_DisplayMinutes_Public_Void_Int32_0;

		// Token: 0x0400795C RID: 31068
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400795D RID: 31069
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400795E RID: 31070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
