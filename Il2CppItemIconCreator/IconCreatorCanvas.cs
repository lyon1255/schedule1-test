using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppItemIconCreator
{
	// Token: 0x02000161 RID: 353
	public class IconCreatorCanvas : MonoBehaviour
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x000C92F8 File Offset: 0x000C74F8
		// Note: this type is marked as 'beforefieldinit'.
		static IconCreatorCanvas()
		{
			Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ItemIconCreator", "IconCreatorCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr);
			IconCreatorCanvas.NativeFieldInfoPtr_textLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "textLabel");
			IconCreatorCanvas.NativeFieldInfoPtr_borders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "borders");
			IconCreatorCanvas.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, "instance");
			IconCreatorCanvas.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100666280);
			IconCreatorCanvas.NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100666281);
			IconCreatorCanvas.NativeMethodInfoPtr_SetTakingPicture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100666282);
			IconCreatorCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr, 100666283);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000C93B4 File Offset: 0x000C75B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101056, XrefRangeEnd = 101060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000C93E8 File Offset: 0x000C75E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101088, RefRangeEnd = 101090, XrefRangeStart = 101060, XrefRangeEnd = 101088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInfo(int totalItens, int currentItem, string itemName, bool isRecording, KeyCode key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref totalItens;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentItem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(itemName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRecording;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000C9464 File Offset: 0x000C7664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101093, RefRangeEnd = 101094, XrefRangeStart = 101090, XrefRangeEnd = 101093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTakingPicture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr_SetTakingPicture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000C9498 File Offset: 0x000C7698
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconCreatorCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconCreatorCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconCreatorCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000104B3 File Offset: 0x0000E6B3
		public IconCreatorCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x000C94D4 File Offset: 0x000C76D4
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x000104BC File Offset: 0x0000E6BC
		public unsafe Text textLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_textLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_textLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x000C9504 File Offset: 0x000C7704
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x000104DB File Offset: 0x0000E6DB
		public unsafe GameObject borders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_borders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconCreatorCanvas.NativeFieldInfoPtr_borders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x000C9534 File Offset: 0x000C7734
		// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x000104FA File Offset: 0x0000E6FA
		public unsafe static IconCreatorCanvas instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IconCreatorCanvas.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconCreatorCanvas>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IconCreatorCanvas.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeFieldInfoPtr_textLabel;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeFieldInfoPtr_borders;

		// Token: 0x040012F7 RID: 4855
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040012F8 RID: 4856
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040012F9 RID: 4857
		private static readonly IntPtr NativeMethodInfoPtr_SetInfo_Public_Void_Int32_Int32_String_Boolean_KeyCode_0;

		// Token: 0x040012FA RID: 4858
		private static readonly IntPtr NativeMethodInfoPtr_SetTakingPicture_Public_Void_0;

		// Token: 0x040012FB RID: 4859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
